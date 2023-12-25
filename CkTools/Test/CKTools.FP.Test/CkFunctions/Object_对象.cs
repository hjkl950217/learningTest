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
            Assert.Equal('c', CkFunctions.Char('c')());
            Assert.Equal("a", CkFunctions.String("a")());
            Assert.Equal((byte)1, CkFunctions.Byte(1)());
            Assert.True(CkFunctions.Bool(true)());
            Assert.Equal(1, CkFunctions.Int(1)());
            Assert.Equal((uint)1, CkFunctions.UInt(1)());
            Assert.Equal((short)1, CkFunctions.Short(1)());
            Assert.Equal((ushort)1, CkFunctions.UShort(1)());
            Assert.Equal(1, CkFunctions.Long(1)());
            Assert.Equal((ulong)1, CkFunctions.ULong(1)());
        }

        #endregion 产量表达式
    }
}