using System;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class 基础函数_CheckNull_检查空
    {
        #region CheckNullWithException

        [Fact]
        public void 参数有空时抛出异常()
        {
            object? notNull = new();

            object? nullArg = null;
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => CkFunctions.CheckNullWithException(notNull, nullArg));

            Assert.NotNull(ex);
        }

        [Fact]
        public void 数组有空时抛出异常()
        {
            object?[] notNullArray = new object?[]
            {
                new object[] { new() },
                null
            };

            object?[]? nullArgArray = null;
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => CkFunctions.CheckNullOrEmptyWithException(notNullArray, nullArgArray));

            Assert.NotNull(ex);
        }

        [Fact]
        public void 数组的元素里面有空值时不报错()
        {
            object?[] notNullArray = new object?[]
            {
               new() ,
               null ,
            };

            try
            {
                //检查多个参数的传递，只检查空和0长度
                //不支持子级空元素的检查，需要时应该让调用方自己处理
                CkFunctions.CheckNullOrEmptyWithException(notNullArray, notNullArray);
            }
            catch(Exception ex)
            {
                Assert.Null(ex);
                throw;
            }
        }

        #endregion CheckNullWithException

        #region IsNull

        [Fact]
        public void 对象为空时返回True()
        {
            object? nullArg = null;
            object? notNullArg = new();
            Assert.True(CkFunctions.IsNull(nullArg, notNullArg));
        }

        [Fact]
        public void 对象不为空时返回False()
        {
            object? notNullArg = new();
            Assert.False(CkFunctions.IsNull(notNullArg, notNullArg));
        }

        [Fact]
        public void 两个对象有空时返回True()
        {
            object? nullArg = null;
            Assert.True(CkFunctions.IsNull(nullArg, nullArg));
        }

        #endregion IsNull

        #region IsNotNull

        [Fact]
        public void 对象不为空时返回True()
        {
            object? notNullArg = new();
            Assert.True(CkFunctions.IsNotNull(notNullArg, notNullArg));
        }

        [Fact]
        public void 对象为空时返回False()
        {
            object? notNullArg = new();
            object? nullArg = null;
            Assert.False(CkFunctions.IsNotNull(notNullArg, nullArg));
        }

        [Fact]
        public void 两个对象有空时返回False()
        {
            object? nullArg = null;
            Assert.False(CkFunctions.IsNotNull(nullArg, nullArg));
        }

        #endregion IsNotNull

        #region IsNullOrEmpty

        [Fact]
        public void 两个数组有空时返回True()
        {
            object?[] notNullArray = new object?[]
            {
                new object[] { new() },
                new object[] { new() },
            };

            Assert.True(CkFunctions.IsNullOrEmpty(notNullArray, null));
        }

        [Fact]
        public void 两个数组没空时返回False()
        {
            object?[] notNullArray = new object?[]
            {
                new object[] { new() },
                new object[] { new() },
            };

            object?[] nullArray = new object?[]
            {
                new object[] { new() },
                null
            };

            Assert.False(CkFunctions.IsNullOrEmpty(notNullArray, nullArray));
        }

        #endregion IsNullOrEmpty

        #region IsNotNullOrEmpty

        [Fact]
        public void 两个数组有空时返回False()
        {
            object?[] notNullArray = new object?[]
              {
                new object[] { new() },
                new object[] { new() },
              };

            Assert.False(CkFunctions.IsNotNullOrEmpty(notNullArray, null));
        }

        [Fact]
        public void 两个数组没空时返回True()
        {
            object?[] notNullArray = new object?[]
                                                                {
                new object[] { new() },
                new object[] { new() },
            };

            object?[] nullArray = new object?[]
                    {
                new object[] { new() },
                null
            };

            Assert.True(CkFunctions.IsNotNullOrEmpty(notNullArray, nullArray));
        }

        #endregion IsNotNullOrEmpty
    }
}