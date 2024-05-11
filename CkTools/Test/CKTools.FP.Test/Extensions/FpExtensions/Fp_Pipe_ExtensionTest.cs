using System;
using Xunit;
using static CKTools.FP.Test.FpMockFunc;

namespace CKTools.FP.Test
{
    public class Fp_Pipe_ExtensionTest
    {
        #region 单独验证

        [Fact]
        public void Action_多入()
        {
            //准备
            //(string->void)->(string->void)->(string->void) => (string->void)
            string str = "1";
            Func<string, string> result = strToVoid
             .Pipe(t => str = t)
             .Pipe(strToVoid);

            //执行
            result("2");

            //断言
            Assert.Equal("2", str);
        }

        [Fact]
        public void Func_0入1出_链接_1入的Action()
        {
            //准备
            //(void->int)->(int->void)->(int->void)) => (void->int)
            int num = 0;
            Func<int> result = 10.ToFunc()
                .Pipe(t => num = t + num)
                .Pipe(t => num = t + num)
                .Pipe(t => num = t + num);

            //执行
            int resultNum = result();
            Assert.Equal(10, resultNum);
            Assert.Equal(30, num);
        }

        [Fact]
        public void Func_1入1出()
        {
            //准备
            //(string->int)->(int->double)->(double->string) => (string->string)
            Func<string, string> result = strToInt
                .Pipe(intToDouble)
                .Pipe(doubleToStr);

            //执行
            string resultNum = result("10");

            //断言
            Assert.Equal("10", resultNum);
        }

        #endregion 单独验证

        //#region 复合验证

        //[Fact]
        //public void Complex_PipeTest()
        //{
        //    //step 1:   (string->int)->(int->double)->(double->string) => (string->string)
        //    //step 2:   (string->string)->(string->void)->...
        //    //expect :  (string->void)

        //    //step 1
        //    FP_Pipe_Extensions.Pipe(strToInt, intToDouble);
        //    Func<string, string> step1 = strToInt
        //        .Pipe(intToDouble)
        //        .Pipe(doubleToStr);

        //    Assert.Equal("1", step1("1"));

        //    //step 2
        //    FP_Pipe_Extensions.Pipe(step1, strToVoid, strToVoid);
        //    Action<string> step2 = step1
        //        .Pipe(strToVoid, strToVoid, strToVoid);

        //    step2("1");
        //}

        //#endregion 复合验证
    }
}