using System;
using Xunit;

namespace CkTools.Test.Test.Extensions.BaseType
{
    public class EnumExtensionTest
    {
        #region 测试数据

        protected enum TestEnumAttr
        {
            [EnumDescription(ShowValue: "-Default-", DbValue: "D", Description: "Default")]
            Default
        }

        protected enum TestEnumByte : byte
        {
            Byte_0x11 = 0x11
        }

        public sealed class TestAttribute : FlagsAttribute
        { }

        #endregion 测试数据

        public class GetValueAndString
        {
            [Fact]
            public void Tc_GetValueString()
            {
                string result = TestEnumAttr.Default.GetValueString();

                Assert.NotNull(result);
                Assert.Equal("0", result);
            }
        }
    }
}