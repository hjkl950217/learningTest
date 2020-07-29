using JT.SDK.Core.Abstract;
using Verification.Core.Helper;

namespace System
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取枚举值对应的名字
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumName(this Enum enumValue)

        {
            return Enum.GetName(enumValue.GetType(), enumValue);
        }

        /// <summary>
        /// 获取枚举值上的特性，获取不到时返回null
        /// </summary>
        /// <typeparam name="TAttribute">枚举上的Attribute类型</typeparam>
        /// <param name="enumValue">枚举值</param>
        public static TAttribute? GetAttribute<TAttribute>(
            this Enum enumValue,
            Func<TAttribute, int>? orderFunc = null)
            where TAttribute : Attribute
        {
            return orderFunc switch
            {
                null => EnumHelper.Instance.GetFirstAttribute<TAttribute>(enumValue),
                _ => EnumHelper.Instance.GetFirstAttribute<TAttribute>(enumValue, orderFunc)
            };
        }

        /// <summary>
        /// 获取枚举值（不是枚举名）对应的字符串类型。<para></para>
        /// 如: AAA.B=1  返回"1"
        /// </summary>
        /// <param name="en">枚举值</param>
        /// <returns>枚举值对应的值类型，字符串表现形式</returns>
        public static string GetValueString(this Enum enumValue)
        {
            return EnumHelper.Instance.GetEnumAttributeData(enumValue).BaseValueString;
        }
    }
}