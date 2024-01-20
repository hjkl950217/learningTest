using System;
using Xunit;

namespace CKTools.FP.Test.Extensions.FpExtensions
{
    public class Fp_Currying_ExtensionsTest
    {
        #region Action

        [Fact]
        public void Action柯里化_2个参数()
        {
            //准备
            int count = 100;
            Action<int, int> process = (t1, t2) => count = t1 + t2 + count;

            //执行
            Action<int> result = process.Currying()(10);
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
            Func<int, Action<int>> result = process.Currying()(10);
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
            Func<int, Func<int, Action<int>>> result = process.Currying()(10);
            result(10)(10)(10);

            //断言
            Assert.Equal(140, count);
        }

        #endregion Action

        #region Func

        [Fact]
        public void Func柯里化_1个参数()
        {
            //准备
            Func<int, int> process = t => t + 100;

            //执行
            Func<int, Func<int>> result = process.Currying();

            //断言
            Assert.Equal(110, result(10)());
        }

        [Fact]
        public void Func柯里化_2个参数()
        {
            //准备
            Func<int, int, int> process = (t1, t2) => t1 + t2 + 100;

            //执行
            Func<int, Func<int, int>> result = process.Currying();

            //断言
            Assert.Equal(120, result(10)(10));
        }

        [Fact]
        public void Func柯里化_3个参数()
        {
            //准备
            Func<int, int, int, int> process = (t1, t2, t3) => t1 + t2 + t3 + 100;

            //执行
            Func<int, Func<int, Func<int, int>>> result = process.Currying();

            //断言
            Assert.Equal(130, result(10)(10)(10));
        }

        [Fact]
        public void Func柯里化_4个参数()
        {
            //准备
            Func<int, int, int, int, int> process = (t1, t2, t3, t4) => t1 + t2 + t3 + t4 + 100;

            //执行
            Func<int, Func<int, Func<int, Func<int, int>>>> result = process.Currying();

            //断言
            Assert.Equal(140, result(10)(10)(10)(10));
        }

        #endregion Func
    }
}