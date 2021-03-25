#pragma warning disable CS8600 // 将 null 文本或可能的 null 值转换为不可为 null 类型。

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Nova.LogicChain.Test.Extensions
{
    public class ObjectExtensionsTest
    {
        #region CheckNull

        [Fact]
        public void CheckNull_True()
        {
            object obj = null;
            ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => obj.CheckNullWithException("test"));

            Assert.NotNull(ex);
        }

        [Fact]
        public void CheckNull_False()
        {
            object obj = new object();
            Exception? ex = Record.Exception(() => obj.CheckNullWithException("test"));

            Assert.Null(ex);
        }

        [Fact]
        public void CheckNull2_True()
        {
            object obj = null;
            ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => obj.CheckNullWithException("test", "testMsg"));

            Assert.NotNull(ex);
            Assert.Contains("testMsg", ex.Message);
        }

        [Fact]
        public void CheckNull2_False()
        {
            object obj = new object();
            Exception? ex = Record.Exception(() => obj.CheckNullWithException("test", "testMsg"));

            Assert.Null(ex);
        }

        #endregion CheckNull

        #region CheckNullOrEmpty

        [Fact]
        public void CheckNullOrEmpty_Null_True()
        {
            List<int> obj = null;
            ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => obj.CheckNullOrEmptyWithException("test"));

            Assert.NotNull(ex);
        }

        [Fact]
        public void CheckNullOrEmpty_Empty_True()
        {
            List<int> obj = new List<int>();
            ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => obj.CheckNullOrEmptyWithException("test"));

            Assert.NotNull(ex);
        }

        [Fact]
        public void CheckNullOrEmpty_False()
        {
            List<int> obj = new List<int>() { 1 };
            Exception? ex = Record.Exception(() => obj.CheckNullOrEmptyWithException("test"));

            Assert.Null(ex);
        }

        [Fact]
        public void CheckNullOrEmpty2_Null_True()
        {
            List<int> obj = null;
            ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => obj.CheckNullOrEmptyWithException("test", "testMsg"));

            Assert.NotNull(ex);
            Assert.Contains("testMsg", ex.Message);
        }

        [Fact]
        public void CheckNullOrEmpty2_Empty_True()
        {
            List<int> obj = new List<int>();
            ArgumentNullException? ex = Assert.Throws<ArgumentNullException>(() => obj.CheckNullOrEmptyWithException("test", "testMsg"));

            Assert.NotNull(ex);
            Assert.Contains("testMsg", ex.Message);
        }

        [Fact]
        public void CheckNullOrEmpty2_False()
        {
            List<int> obj = new List<int>() { 1 };
            Exception? ex = Record.Exception(() => obj.CheckNullOrEmptyWithException("test", "testMsg"));

            Assert.Null(ex);
        }

        #endregion CheckNullOrEmpty

        #region ToTask

        [Fact]
        public void ToTask_NullObject_NotException()
        {
            object obj = null;
            Task<object> result = null;
            Exception? ex = Record.Exception(() => { result = obj.ToTask(); });

            Assert.Null(ex);
            Assert.True(result.IsCompleted);
            Assert.Null(result.Result);
        }

        [Fact]
        public void ToTask_String_NotException()
        {
            string obj = "123";

            Task<string> result = null;

            Exception? ex = Record.Exception(() => { result = obj.ToTask(); });

            Assert.Null(ex);
            Assert.True(result.IsCompleted);
            Assert.Equal(obj, result.Result);
        }

        #endregion ToTask
    }
}

#pragma warning restore CS8600 // 将 null 文本或可能的 null 值转换为不可为 null 类型。