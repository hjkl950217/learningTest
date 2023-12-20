using System;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class Currying_柯里化
    {
        #region Action

        [Fact]
        public void Action柯里化_0个参数()
        {
            //准备
            int count = 0;
            Action process = () => count = 100;

            //执行
            Action result = CkFunctions.Currying(process);
            result();

            //断言
            Assert.Equal(100, count);
        }

        [Fact]
        public void Action柯里化_1个参数()
        {
            //准备
            int count = 100;
            Action<int> process = t1 => count = t1 + count;

            //执行
            Action<int> result = CkFunctions.Currying(process);
            result(20);

            //断言
            Assert.Equal(120, count);
        }

        [Fact]
        public void Action柯里化_2个参数()
        {
            //准备
            int count = 100;
            Action<int, int> process = (t1, t2) => count = t1 + t2 + count;

            //执行
            Action<int> result = CkFunctions.Currying(process)(10);
            result(10);

            //断言
            Assert.Equal(120, count);
        }

        [Fact]
        public void Action柯里化_3个参数()
        {
            //准备
            int count = 100;
            Action<int, int, int> process = (t1, t2, t3) => count = t1 + t2 + t3 + count;

            //执行
            Func<int, Action<int>> result = CkFunctions.Currying(process)(10);
            result(10)(10);

            //断言
            Assert.Equal(130, count);
        }

        [Fact]
        public void Action柯里化_4个参数()
        {
            //准备
            int count = 100;
            Action<int, int, int, int> process = (t1, t2, t3, t4) => count = t1 + t2 + t3 + t4 + count;

            //执行
            Func<int, Func<int, Action<int>>> result = CkFunctions.Currying(process)(10);
            result(10)(10)(10);

            //断言
            Assert.Equal(140, count);
        }

        #endregion Action

        #region Func

        [Fact]
        public void Func柯里化_0个参数()
        {
            //准备
            Func<int> process = () => 100;

            //执行
            Func<int> result = CkFunctions.Currying(process);

            //断言
            Assert.Equal(100, result());
        }

        [Fact]
        public void Func柯里化_1个参数()
        {
            //准备
            Func<int, int> process = t1 => t1 + 100;

            //执行
            Func<int, int> result = CkFunctions.Currying(process);

            //断言
            Assert.Equal(120, result(20));
        }

        [Fact]
        public void Func柯里化_2个参数()
        {
            //准备
            Func<int, int, int> process = (t1, t2) => t1 + t2 + 100;

            //执行
            Func<int, Func<int, int>> result = CkFunctions.Currying(process);

            //断言
            Assert.Equal(120, result(10)(10));
        }

        [Fact]
        public void Func柯里化_3个参数()
        {
            //准备
            Func<int, int, int, int> process = (t1, t2, t3) => t1 + t2 + t3 + 100;

            //执行
            Func<int, Func<int, Func<int, int>>> result = CkFunctions.Currying(process);

            //断言
            Assert.Equal(130, result(10)(10)(10));
        }

        [Fact]
        public void Func柯里化_4个参数()
        {
            //准备
            Func<int, int, int, int, int> process = (t1, t2, t3, t4) => t1 + t2 + t3 + t4 + 100;

            //执行
            Func<int, Func<int, Func<int, Func<int, int>>>> result = CkFunctions.Currying(process);

            //断言
            Assert.Equal(140, result(10)(10)(10)(10));
        }

        #endregion Func
    }
}