using CkTools.Extensions.BaseType;

namespace System
{
    public static class TimeZoneInfoExtensions
    {
        /// <summary>
        /// 获取时区的偏移字符串(如: +08:00、-07:15)
        /// </summary>
        /// <param name="timeZoneInfo"></param>
        /// <returns></returns>
        public static string GetOffsetString(this TimeZoneInfo timeZoneInfo)
        {
            return $"{timeZoneInfo.GetOffsetSymbol()}{timeZoneInfo.BaseUtcOffset.Hours.Abs():00}:{timeZoneInfo.BaseUtcOffset.Minutes:00}";
        }

        /// <summary>
        /// 获取相对UTC时区的偏移符号,返回+或-
        /// </summary>
        /// <param name="timeZoneInfo"></param>
        /// <returns></returns>
        public static string GetOffsetSymbol(this TimeZoneInfo timeZoneInfo)
        {
            return timeZoneInfo.BaseUtcOffset.Hours > 0 ? "+" : "-";
        }
    }
}