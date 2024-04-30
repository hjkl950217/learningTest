//using System;
//using Xunit;
//using static CKTools.FP.Test.FpMockFunc;

//namespace CKTools.FP.Test
//{
//    public class Fp_Do_ExtensionTest
//    {
//        // 扩展函数 Fp_Compose 完成是 CkFunctions.Compose的镜像
//        // 它太多了，而且只是简单的调用，不再单独写测试
//        // 这里写一点常见情况的测试

//        #region 单独验证

//        [Fact]
//        public void DoTest1()
//        {
//            // (string->int)->(int->void)->... => (string->int)
//            Func<string, int> result = strToInt.Pipe(intToVoid);

//            Assert.Equal(1, result("1"));
//        }

//        [Fact]
//        public void DoTest2()
//        {
//            //导航
//            //   FP_Do_Extensions.Do(strToVoid, strToVoid, strToVoid);

//            //(string->void)->(string->void)->...  => (string->void)
//            Action<string> result = strToVoid
//                .Do(strToVoid, strToVoid, strToVoid, strToVoid);

//            result("1");
//        }

//        #endregion 单独验证

//        #region 复合验证

//        [Fact]
//        public void Complex_DoTest()
//        {
//            //step 1:   (string->int)->(int->void)->... => (string->int)
//            //step 2:   (string->int)->(int->double) => (string->double)
//            //expect :  (string->double)

//            //step 1
//            FP_Do_Extensions.Do(intToVoid, intToVoid, intToVoid);
//            Func<string, int> step1 = strToInt.Do(intToVoid, intToVoid, intToVoid);
//            Assert.Equal(1, step1("1"));

//            //stop 2
//            Func<string, double> step2 = step1.Pipe(intToDouble);

//            Assert.Equal(1.00d, step2("1"));
//        }

//        #endregion 复合验证
//    }
//}