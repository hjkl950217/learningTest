using System;
using Xunit;
using static Verification.Core.Test.Extensions.FpExtension.FpMockHelper;

namespace Verification.Core.Test.Extensions
{
    public class Fp_Pipe_ExtensionTest
    {
        #region 单独验证

        [Fact]
        public void PipeTest1()
        {
            //导航
            FP_Pipe_Extension.Pipe(strToInt, intToDouble);

            //(string->int)->(int->double)->(double->string)  => (string->string)
            Func<string, string> result = strToInt
                .Pipe(intToDouble)
                .Pipe(doubleToStr);

            Assert.Equal("1", result("1"));
        }

        [Fact]
        public void PipeTest2()
        {
            //导航
            FP_Pipe_Extension.Pipe(strToInt, intToVoid);

            //(string->int)->(int->void) => (string->void)
            Action<string> result = strToInt
                .Pipe(intToVoid);

            result("");
        }

        [Fact]
        public void PipeTest3()
        {
            //导航
            FP_Pipe_Extension.Pipe(strToVoid, strToVoid, strToVoid);

            //(string->void)->(string->void)->...  => (string->void)
            Action<string> result = strToVoid
                .Pipe(strToVoid, strToVoid, strToVoid, strToVoid);

            result("");
        }

        [Fact]
        public void PipeTest4()
        {
            //导航
            FP_Pipe_Extension.Pipe(strToInt, intToVoid, intToVoid);

            //(string->int)->(int->void)->...  => (string->void)
            Action<string> result = strToInt.Pipe(intToVoid, intToVoid, intToVoid);

            result("");
        }

        #endregion 单独验证

        #region 复合验证

        [Fact]
        public void Complex_PipeTest()
        {
            //step 1:   (string->int)->(int->double)->(double->string)  => (string->string)
            //step 2:   (string->string)->(string->void)->...
            //expect :  (string->void)

            //step 1
            FP_Pipe_Extension.Pipe(strToInt, intToDouble);
            Func<string, string> step1 = strToInt
                .Pipe(intToDouble)
                .Pipe(doubleToStr);

            Assert.Equal("1", step1("1"));

            //step 2
            FP_Pipe_Extension.Pipe(step1, strToVoid, strToVoid);
            Action<string> step2 = step1
                .Pipe(strToVoid, strToVoid, strToVoid);

            step2("1");
        }

        #endregion 复合验证
    }

    public class Fp_Do_ExtensionTest
    {
        #region 单独验证

        [Fact]
        public void DoTest1()
        {
            //导航
            Fp_Do_Extension.Do(strToInt, intToVoid);

            // (string->int)->(int->void)->... => (string->int)
            Func<string, int> result = strToInt.Do(intToVoid);

            Assert.Equal(1, result("1"));
        }

        [Fact]
        public void DoTest2()
        {
            //导航
            FP_Pipe_Extension.Pipe(strToVoid, strToVoid, strToVoid);

            //(string->void)->(string->void)->...  => (string->void)
            Action<string> result = strToVoid
                .Do(strToVoid, strToVoid, strToVoid, strToVoid);

            result("");
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
            Func<string, int> step1 = strToInt.Do(intToVoid, intToVoid, intToVoid);
            Assert.Equal(1, step1("1"));

            //stop 2
            Func<string, double> step2 = step1.Pipe(intToDouble);

            Assert.Equal(1.00d, step2("1"));
        }

        #endregion 复合验证
    }
}