using System.Collections;
using System.Collections.Generic;
using CkTools.FP.Extensions.ObjectExtensions;
using Xunit;

namespace CKTools.FP.Test.Extensions.FpExtensions
{
    public class Fp_CheckNull_ExtensionsTest
    {
        [Fact]
        public void 检查空_空对象()
        {
            //准备
            object? obj = null;

            //执行
            bool result = obj.IsNull();

            //断言
            Assert.True(result);
        }

        [Fact]
        public void 检查空_非空对象()
        {
            //准备
            object? obj = new();

            //执行
            bool result = obj.IsNull();

            //断言
            Assert.False(result);
        }

        [Fact]
        public void 检查非空_空对象()
        {
            //准备
            object? obj = null;

            //执行
            bool result = obj.IsNotNull();

            //断言
            Assert.False(result);
        }

        [Fact]
        public void 检查非空_非空对象()
        {
            //准备
            object? obj = new();

            //执行
            bool result = obj.IsNotNull();

            //断言
            Assert.True(result);
        }

        [Fact]
        public void 检查空集合_空集合()
        {
            //准备
            IEnumerable? array = null;

            //执行
            bool result = array.IsNullOrEmpty();

            //断言
            Assert.True(result);
        }

        [Fact]
        public void 检查空集合_非空集合()
        {
            //准备
            IEnumerable? array = new List<object>() { new() };

            //执行
            bool result = array.IsNullOrEmpty();

            //断言
            Assert.False(result);
        }

        [Fact]
        public void 检查非空集合_空集合()
        {
            //准备
            IEnumerable? array = null;

            //执行
            bool result = array.IsNotNullOrEmpty();

            //断言
            Assert.False(result);
        }

        [Fact]
        public void 检查非空集合_非空集合()
        {
            //准备
            IEnumerable? array = new List<object>() { new() };

            //执行
            bool result = array.IsNotNullOrEmpty();

            //断言
            Assert.True(result);
        }
    }
}