using System;
using Xunit;
using static Verification.Core.Test.Extensions.FpExtension.FpMockFunc;

namespace Verification.Core.Test.Extensions
{
    public class Fp_CurryingTest
    {
        #region Action

        [Fact]
        public void Action_CurryingTest1()
        {
            //导航
            Fp_Currying_Extensions.Currying(intToVoid);

            int tempResult = 0;

            Action result = intToVoid
                .Do(t => tempResult = t)
                .Currying()(5);   // (int->void)->5 => (()->void)

            result();

            Assert.Equal(5, tempResult);
        }

        //todo: 实现pipe do中更多参数的代码，才能继续这里的UT

        //[Fact]
        //public void Action_CurryingTest1()
        //{
        //    Action<int, string> testAction = (x, y) => { };

        //    //导航
        //    Fp_Currying_Extensions.Currying(testAction);

        //    int tempResult = 0;
        //    string tempResult2 = "";

        //    Action result = testAction
        //        .Do((x, y) => { tempResult = x; tempResult2 = y; })
        //        .Currying()(5);   // (int->void)->5 => (void->void)

        //    result();

        //    Assert.Equal(5, tempResult);
        //}

        #endregion Action

        #region Func

        [Fact]
        public void CurryingTest1()
        {
            //导航
            Fp_Currying_Extensions.Currying(intToString);

            // (int->string)->1 => (()->string)
            Func<string> result = intToString.Currying()(1);

            Assert.Equal("", result());
        }

        #endregion Func
    }
}