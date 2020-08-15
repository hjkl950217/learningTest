using System;
using System.Collections.Generic;
using System.Linq;
using CkTools.Helper;
using Xunit;

namespace CkTools.Test.Test.Helper.ClassHelper
{
    public class EnumHelperTest
    {
        #region 测试枚举

        protected enum TestEnumAttr
        {
            [EnumDescription(ShowValue: "-Default-", DbValue: "D", Description: "Default")]
            Default
        }

        protected enum TestEnumByte : byte
        {
            Byte_0x11 = 0x11
        }

        protected enum TestEnumNull
        {
        }

        public sealed class TestAttribute : FlagsAttribute
        { }

        protected enum TestEnumMps
        {
            [EnumDescription(ShowValue: "-AllValue-", DbValue: "M", Description: "AllValue")]
            AllValue,

            [EnumDescription(ShowValue: null, DbValue: null, Description: null)]
            AllNull,

            [EnumDescription(ShowValue: null, DbValue: "M", Description: "ShowValueNull")]
            ShowValueNull,

            [EnumDescription(ShowValue: "-DBValue-", DbValue: null, Description: "DBValue")]
            DBValue,

            [EnumDescription(ShowValue: "-DescriptionNull-", DbValue: "M", Description: null)]
            DescriptionNull,

            NoAttribute,
        }

        #endregion 测试枚举

        public class GetEnumStructTest
        {
            [Fact]
            public void TC_GetStruct_Value()
            {
                IReadOnlyDictionary<string, byte> result = EnumHelper.Instance.GetEnumStruct<TestEnumByte, byte>();

                Assert.NotNull(result);
                Assert.Equal(TestEnumByte.Byte_0x11.ToString(), result.First().Key);
                Assert.IsType<byte>(result.First().Value);
                Assert.Equal(17, result.First().Value);
            }

            [Fact]
            public void TC_GetStruct_Value_String()
            {
                IReadOnlyDictionary<string, string> result = EnumHelper.Instance.GetEnumStructString<TestEnumByte>();

                Assert.NotNull(result);
                Assert.Equal(TestEnumByte.Byte_0x11.ToString(), result.First().Key);
                Assert.IsType<string>(result.First().Value);
                Assert.Equal($"{0x11}", result.First().Value);
            }

            [Fact]
            public void TC_GetStruct_Value_Exception()
            {
                InvalidCastException result = Assert.Throws<InvalidCastException>(() =>
                {
                    EnumHelper.Instance.GetEnumStruct<TestEnumByte, char>();
                });

                Assert.NotNull(result);
                Assert.NotNull(result.InnerException);
                Assert.Contains("获取枚举结构时，枚举值的类型传递错误。", result.Message);
                Assert.Contains("枚举名:TestEnumByte", result.Message);
            }

            [Fact]
            public void TC_GetStruct_String()
            {
                IReadOnlyDictionary<string, string> result = EnumHelper.Instance.GetEnumStructString<TestEnumByte>();

                Assert.NotNull(result);
                Assert.Equal(TestEnumByte.Byte_0x11.ToString(), result.First().Key);
                Assert.IsType<string>(result.First().Value);
                Assert.Equal("17", result.First().Value);
            }
        }

        public class GetAttributeTest
        {
            [Fact]
            public void Tc_GetAttribute_Null()
            {
                Attribute result = TestEnumAttr.Default.GetAttribute<FlagsAttribute>();

                Assert.Null(result);
            }

            [Fact]
            public void Tc_GetAttribute()
            {
                EnumDescriptionAttribute result = TestEnumAttr.Default.GetAttribute<EnumDescriptionAttribute>();

                Assert.NotNull(result);
                Assert.Equal("-Default-", result.ShowValue);
                Assert.Equal("D", result.DBValue);
                Assert.Equal("Default", result.Description);
            }
        }
    }
}