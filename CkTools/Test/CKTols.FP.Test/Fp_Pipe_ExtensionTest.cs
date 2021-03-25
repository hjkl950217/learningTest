﻿//using System;
//using Xunit;
//using static CKTols.FP.Test.FpMockFunc;

//namespace CKTols.FP.Test
//{
//    public class Fp_Pipe_ExtensionTest
//    {
//        #region 单独验证

//        [Fact]
//        public void PipeTest1()
//        {
//            //导航
//            FP_Pipe_Extensions.Pipe(strToInt, intToDouble);

//            //(string->int)->(int->double)->(double->string)  => (string->string)
//            Func<string, string> result = strToInt
//                .Pipe(intToDouble)
//                .Pipe(doubleToStr);

//            Assert.Equal("1", result("1"));
//        }

//        [Fact]
//        public void PipeTest2()
//        {
//            //导航
//            FP_Pipe_Extensions.Pipe(strToInt, intToVoid);

//            //(string->int)->(int->void) => (string->void)
//            Action<string> result = strToInt
//                .Pipe(intToVoid);

//            result("1");
//        }

//        [Fact]
//        public void PipeTest3()
//        {
//            //导航
//            FP_Pipe_Extensions.Pipe(strToVoid, strToVoid, strToVoid);

//            //(string->void)->(string->void)->...  => (string->void)
//            Action<string> result = strToVoid
//                .Pipe(strToVoid, strToVoid, strToVoid, strToVoid);

//            result("1");
//        }

//        [Fact]
//        public void PipeTest4()
//        {
//            //导航
//            FP_Pipe_Extensions.Pipe(strToInt, intToVoid, intToVoid);

//            //(string->int)->(int->void)->...  => (string->void)
//            Action<string> result = strToInt.Pipe(intToVoid, intToVoid, intToVoid);

//            result("1");
//        }

//        #endregion 单独验证

//        #region 复合验证

//        [Fact]
//        public void Complex_PipeTest()
//        {
//            //step 1:   (string->int)->(int->double)->(double->string)  => (string->string)
//            //step 2:   (string->string)->(string->void)->...
//            //expect :  (string->void)

//            //step 1
//            FP_Pipe_Extensions.Pipe(strToInt, intToDouble);
//            Func<string, string> step1 = strToInt
//                .Pipe(intToDouble)
//                .Pipe(doubleToStr);

//            Assert.Equal("1", step1("1"));

//            //step 2
//            FP_Pipe_Extensions.Pipe(step1, strToVoid, strToVoid);
//            Action<string> step2 = step1
//                .Pipe(strToVoid, strToVoid, strToVoid);

//            step2("1");
//        }

//        #endregion 复合验证
//    }
//}