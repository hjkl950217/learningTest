using System;
using JT.SDK.Core.Abstract;

namespace Verification.Core
{
    public static class EnumDescriptionAttributeExtensions
    {
        private static string? GetAttributeValue(this Enum enumValue, Func<EnumDescriptionAttribute?, string?> getFunc)
        {
            var attribute = EnumHelper.Instance.GetFirstAttribute<EnumDescriptionAttribute>(enumValue);

            if (attribute.IsNullOrEmpty()) return string.Empty;

            return getFunc(attribute);
        }

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
    }
}