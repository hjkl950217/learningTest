using System;
using CkTools.FP;
using Xunit;

namespace CKTools.FP.Test
{
    public class Object_对象
    {
        #region 产量表达式

        [Fact]
        public void Constant_值直接转换为常量表达式()
        {
            //准备
            object obj = new();

            //执行
            Func<object> result = CkFunctions.Constant(obj);

            //断言
            Assert.Equal(obj, result());
        }

        [Fact]
        public void Constant_类型转换为常量表达式()
        {
            //准备

            //执行

            //断言
            Assert.Equal("a", CkFunctions.Constant<string>()("a")());
            Assert.Equal((byte)1, CkFunctions.Constant<byte>()(1)());
            Assert.True(CkFunctions.Constant<bool>()(true)());
            Assert.Equal(1, CkFunctions.Constant<int>()(1)());
            Assert.Equal((uint)1, CkFunctions.Constant<uint>()(1)());
            Assert.Equal((short)1, CkFunctions.Constant<short>()(1)());
            Assert.Equal((ushort)1, CkFunctions.Constant<ushort>()(1)());
            Assert.Equal(1, CkFunctions.Constant<long>()(1)());
            Assert.Equal((ulong)1, CkFunctions.Constant<ulong>()(1)());
        }

        #endregion 产量表达式
    }
}