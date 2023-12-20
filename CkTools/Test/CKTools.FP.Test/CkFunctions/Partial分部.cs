using System;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class Partial分部
    {
        #region Action

        [Fact]
        public void Action_1个参数()
        {
            //准备
            int count = 100;
            Action<int> process = t1 => count = t1 + count;

            //执行
            Action<int> result = CkFunctions.Partial(process);
            result(20);

            //断言
            Assert.Equal(120, count);
        }

        [Fact]
        public void Action_2个参数()
        {
            //准备
            int count = 100;
            Func<int, Action<int>> process = t1 => t2 => count = t1 + t2 + count;

            //执行
            Action<int, int> result = CkFunctions.Partial(process);
            result(10, 10);

            //断言
            Assert.Equal(120, count);
        }

        [Fact]
        public void Action_3个参数()
        {
            //准备
            int count = 100;
            Func<int, Func<int, Action<int>>> process = t1 => t2 => t3 => count = t1 + t2 + t3 + count;

            //执行
            Action<int, int, int> result = CkFunctions.Partial(process);
            result(10, 10, 10);

            //断言
            Assert.Equal(130, count);
        }

        [Fact]
        public void Action_4个参数()
        {
            //准备
            int count = 100;
            Func<int, Func<int, Func<int, Action<int>>>> process = t1 => t2 => t3 => t4 => count = t1 + t2 + t3 + t4 + count;

            //执行
            Action<int, int, int, int> result = CkFunctions.Partial(process);
            result(10, 10, 10, 10);

            //断言
            Assert.Equal(140, count);
        }

        #endregion Action

        #region Func

        [Fact]
        public void Func_1个参数()
        {
            //准备
            int count = 100;
            Func<int, int> process = t1 => t1 + count;

            //执行
            Func<int, int> result = CkFunctions.Partial(process);
            int resultValue = result(20);

            //断言
            Assert.Equal(120, resultValue);
        }

        [Fact]
        public void Func_2个参数()
        {
            //准备
            int count = 100;
            Func<int, Func<int, int>> process = t1 => t2 => t1 + t2 + count;

            //执行
            Func<int, int, int> result = CkFunctions.Partial(process);
            int resultValue = result(10, 10);

            //断言
            Assert.Equal(120, resultValue);
        }

        [Fact]
        public void Func_3个参数()
        {
            //准备
            int count = 100;
            Func<int, Func<int, Func<int, int>>> process = t1 => t2 => t3 => t1 + t2 + t3 + count;

            //执行
            Func<int, int, int, int> result = CkFunctions.Partial(process);
            int resultValue = result(10, 10, 10);

            //断言
            Assert.Equal(130, resultValue);
        }

        [Fact]
        public void Func_4个参数()
        {
            //准备
            int count = 100;
            Func<int, Func<int, Func<int, Func<int, int>>>> process = t1 => t2 => t3 => t4 => t1 + t2 + t3 + t4 + count;

            //执行
            Func<int, int, int, int, int> result = CkFunctions.Partial(process);
            int resultValue = result(10, 10, 10, 10);

            //断言
            Assert.Equal(140, resultValue);
        }

        #endregion Func
    }
}