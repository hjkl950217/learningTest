using System;

namespace Verification.Core
{
    public static class StringExtension
    {
        /// <summary>
        /// 判断两个字符串是否相等，忽略大小写
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(this string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 判断两个字符串是否相等，忽略大小写，忽略首尾空格
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool EqualsLoose(this string str1, string str2)
        {
            return string.Equals(str1?.Trim(), str2?.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}