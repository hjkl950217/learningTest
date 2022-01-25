//using System;
//using Xunit;

//namespace CKTols.FP.Test
//{
//    public class FpObjectPipeExtensionTest
//    {
//        #region 单独验证

//        [Fact]
//        public void ObjectPipeTest1()
//        {
//            int a = 1;

//            bool result = ObjectExt_Pipe.Pipe(a, t => t == 1);
//            Assert.True(result);
//        }

//        #endregion 单独验证

//        #region 复合验证

//        [Fact]
//        public void Complex_ObjectPipeTest1()
//        {
//            byte a = 0x63;//c的16进制

//            string result = a
//                .Pipe(t => (int)t)//byte -> int
//                .PipeIf(true, t => t + 1)//加1后变成100 d的asc码
//                .Pipe(t => (char)t)//int -> char
//                .Pipe(t => new char[1] { t })//char -> char[]
//                .Pipe(t => new string(t));//char[] -> string

//            Assert.Equal("d", result);
//        }

//        #endregion 复合验证
//    }
//}