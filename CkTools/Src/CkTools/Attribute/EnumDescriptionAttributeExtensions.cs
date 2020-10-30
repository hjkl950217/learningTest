#pragma warning disable CS8604 // 可能的 null 引用参数。

using CkTools.Helper;
using System;

namespace CkTools.Attribute
{
    public static class EnumDescriptionAttributeExtensions
    {
        /// <summary>
        /// 获取枚举上的<see cref="EnumDescriptionAttribute.ShowValue"/>,获取不到时返回<see cref="string.Empty"/>
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string? GetShowValue(this Enum enumValue)
        {
            return GetAttributeValue(enumValue, t => t.ShowValue);
        }

        /// <summary>
        /// 获取枚举上的<see cref="EnumDescriptionAttribute.DBValue"/>,获取不到时返回<see cref="string.Empty"/>
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string? GetDBValue(this Enum enumValue)
        {
            return GetAttributeValue(enumValue, t => t.DBValue);
        }

        /// <summary>
        /// 获取枚举上的<see cref="EnumDescriptionAttribute.Description"/>,获取不到时返回<see cref="string.Empty"/>
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string? GetDescription(this Enum enumValue)
        {
            return GetAttributeValue(enumValue, t => t.Description);
        }

        private static string? GetAttributeValue(this Enum enumValue, Func<EnumDescriptionAttribute, string> getFunc)
        {
            EnumDescriptionAttribute? attribute = EnumHelper.Instance.GetFirstAttribute<EnumDescriptionAttribute>(enumValue);

            if (attribute.IsNullOrEmpty()) return string.Empty;

            return getFunc(arg: attribute);
        }
    }
}

#pragma warning restore CS8604 // 可能的 null 引用参数。