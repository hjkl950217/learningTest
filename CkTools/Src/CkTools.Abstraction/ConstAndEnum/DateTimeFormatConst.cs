﻿namespace CkTools.Abstraction.ConstAndEnum
{
    public static class DateTimeFormatConst
    {
        /// <summary>
        /// .net core使用的时间格式
        /// <para>格式：yyyy-MM-ddTHH:mm:ss.fffffffK。例：2017-12-11T21:50:02.1234568+08:00</para>
        /// <para>等同于'o' 'O' 表示：利用ISO 8601规定的表示时区信息 输出的字符串 </para>
        /// <para>Newtonsoft.Json中会少一个f</para>
        /// <para>资料：https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/standard-date-and-time-format-strings#the-round-trip-o-o-format-specifier </para>
        /// </summary>
        public const string Standard = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";
    }
}