using System;
using Xunit;
using static Verification.Core.Test.Extensions.FpExtension.FpMockFunc;

namespace Verification.Core.Test.Extensions
{
    public class Fp_Do_ExtensionTest
    {
        #region 单独验证

        [Fact]
        public void DoTest1()
        {
            //导航
            Fp_Do_Extensions.Do(strToInt, intToVoid);

            // (string->int)->(int->void)->... => (string->int)
            Func<string, int> result = strToInt.Do(intToVoid);

            Assert.Equal(1, result("1"));
        }

        [Fact]
        public void DoTest2()
        {
            //导航
            Fp_Do_Extensions.Do(strToVoid, strToVoid, strToVoid);

            //(string->void)->(string->void)->...  => (string->void)
            Action<string> result = strToVoid
                .Do(strToVoid, strToVoid, strToVoid, strToVoid);

            result("1");
        }

        #endregion 单独验证

        #region 复合验证

        [Fact]
        public void Complex_DoTest()
        {
            //step 1:   (string->int)->(int->void)->... => (string->int)
            //step 2:   (string->int)->(int->double) => (string->double)
            //expect :  (string->double)

            //step 1
            Fp_Do_Extensions.Do(intToVoid, intToVoid, intToVoid);
            Func<string, int> step1 = strToInt.Do(intToVoid, intToVoid, intToVoid);
            Assert.Equal(1, step1("1"));

            //stop 2
            Func<string, double> step2 = step1.Pipe(intToDouble);

            Assert.Equal(1.00d, step2("1"));
        }

        #endregion 复合验证
    }
}