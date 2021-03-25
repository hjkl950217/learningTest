using CkTools.Attribute;
using System;

namespace CKTools.BaseExtensions.Test.Helper.EnumHelper
{
    internal enum TestEnumAttr
    {
        [EnumDescription(ShowValue: "-Default-", DbValue: "D", Description: "Default")]
        Default
    }

    internal enum TestEnumByte : byte
    {
        Byte_0x11 = 0x11
    }

    internal enum TestEnumMps
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

    internal sealed class TestAttribute : FlagsAttribute
    { }
}