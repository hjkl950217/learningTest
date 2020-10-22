namespace System
{
    public static class TypeConvertDelegate
    {
        #region 基础转换

        public static Func<string, long> stringToLong = System.Convert.ToInt64;

        /// <summary>
        /// int转bool,大于0为true
        /// </summary>
        public static Func<int, bool> intToBool = t => t > 0 ? true : false;

        #region To DateTimeOffset

        public static Func<string, DateTimeOffset> stringToDateTimeOffset = DateTimeOffset.Parse;
        public static Func<long, DateTimeOffset> longToUtcDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds;
        public static Func<long, DateTimeOffset> longToUtcDateTimeOffsetByMilliseconds = DateTimeOffset.FromUnixTimeMilliseconds;
        public static Func<DateTimeOffset, DateTimeOffset> utcToLocal = t => t.AddOffset(TimeZoneInfo.Local.BaseUtcOffset);
        public static Func<DateTimeOffset, DateTimeOffset> localToUtc = t => t.AddOffset(-TimeZoneInfo.Local.BaseUtcOffset);

        #endregion To DateTimeOffset

        #region To DateTime

        /// <summary>
        ///
        /// </summary>
        public static Func<long, DateTime> longToDatetime =>
          ts => TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local)
               + TimeSpan.FromSeconds(ts);

        #endregion To DateTime

        #endregion 基础转换

        #region 组合转换

        public static Func<string, DateTimeOffset> longStringToUtcDateTimeOffset = stringToLong
            .Pipe(longToUtcDateTimeOffset);

        public static Func<string, DateTimeOffset> longStringToLocalDateTimeOffset = stringToLong
            .Pipe(longToUtcDateTimeOffset)
            .Pipe(utcToLocal);

        public static Func<string, DateTimeOffset> longStringToUtcDateTimeOffsetByMilliseconds = stringToLong
            .Pipe(longToUtcDateTimeOffsetByMilliseconds);

        public static Func<string, DateTimeOffset> longStringToLocalDateTimeOffsetByMilliseconds = stringToLong
            .Pipe(longToUtcDateTimeOffsetByMilliseconds)
            .Pipe(utcToLocal);

        #endregion 组合转换
    }
}