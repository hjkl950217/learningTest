//using System;
//using System.Threading.Tasks;
//using Xunit;

//namespace CKTools.FP.Test
//{
//    public class FpObjectPipeAsyncExtensionTest
//    {
//        #region 单独验证

//        [Fact]
//        public void ObjectPipeAsyncTest1()
//        {
//            Task<int> a = Task.Run(() => 1);

//            Task<bool> task = FpObjectPipeAsyncExtensions.PipeAsync(a, t => t == 1);
//            task.Wait();

//            Assert.True(task.Result);
//        }

//        #endregion 单独验证

//        #region 复合验证

//        [Fact]
//        public void Complex_ObjectPipeAsyncTest1()
//        {
//            byte a = 0x63;//c的16进制 99

//            Task<string> result = a
//                .Pipe(t => (int)t)//byte -> int
//                .PipeIf(true, t => t + 1)//加1后变成100 d的asc码
//                .Pipe(t => Task.Run(() => t))
//                .PipeAsync(t => (char)t)//int -> char
//                .PipeAsync(t => new char[1] { t })//char -> char[]
//                .PipeAsync(t => new string(t));//char[] -> string

//            result.Wait();

//            Assert.Equal("d", result.Result);
//        }

//        #endregion 复合验证
//    }
//}