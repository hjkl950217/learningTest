#pragma warning disable CS8604 // 可能的 null 引用参数。
#pragma warning disable CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。

using System;
using System.Collections;
using Xunit;

namespace CkTools.Abstraction.Test.Extensions
{
    public class EnumerableExtensions
    {
        #region IsNullOrEmpty

        [Fact]
        public void IsNullOrEmpty_Null_True()
        {
            IEnumerable testObject = null;
            bool result = testObject.IsNullOrEmpty();
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_Empty_True()
        {
            IEnumerable testObject = new int[0];
            bool result = testObject.IsNullOrEmpty();
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_ZeroIsNull_Fasle()
        {
            IEnumerable testObject = new string[2] { null, null };

            bool result = testObject.IsNullOrEmpty();
            Assert.False(result);
        }

        [Fact]
        public void IsNullOrEmpty_TwoElement_Fasle()
        {
            IEnumerable testObject = new string[2] { "1", "1" };
            bool result = testObject.IsNullOrEmpty();
            Assert.False(result);
        }

        #endregion IsNullOrEmpty

        #region IsNotNullOrEmpty

        [Fact]
        public void IsNotNullOrEmpty_Null_Fasle()
        {
            IEnumerable testObject = null;

            bool result = testObject.IsNotNullOrEmpty();

            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrEmpty_Empty_Fasle()
        {
            IEnumerable testObject = new int[0];
            bool result = testObject.IsNotNullOrEmpty();
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrEmpty_ZeroIsNull_True()
        {
            IEnumerable testObject = new string[2] { null, null };
            bool result = testObject.IsNotNullOrEmpty();
            Assert.True(result);
        }

        [Fact]
        public void IsNotNullOrEmpty_TwoElement_True()
        {
            IEnumerable testObject = new string[2] { "1", "1" };
            bool result = testObject.IsNotNullOrEmpty();
            Assert.True(result);
        }

        #endregion IsNotNullOrEmpty
    }
}

#pragma warning restore CS8625 // 无法将 null 文本转换为不可为 null 的引用类型。
#pragma warning restore CS8604 // 可能的 null 引用参数。