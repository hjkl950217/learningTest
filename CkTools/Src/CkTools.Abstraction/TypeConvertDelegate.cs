namespace System
{
    public static partial class TypeConvertDelegate
    {
        #region 基础转换

        #region To Long

        public static Func<string, long> stringToLong = System.Convert.ToInt64;

        #endregion To Long

        #region To Bool

        /// <summary>
        /// int转bool,大于0为true
        /// </summary>
        public static Func<int, bool> intToBool = t => t > 0;

        #endregion To Bool

        #region To DateTimeOffset

        public static Func<string, DateTimeOffset> stringToDateTimeOffset = DateTimeOffset.Parse;
        public static Func<long, DateTimeOffset> longToUtcDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds;
        public static Func<long, DateTimeOffset> longToUtcDateTimeOffsetByMilliseconds = DateTimeOffset.FromUnixTimeMilliseconds;
        public static Func<DateTimeOffset, DateTimeOffset> utcToLocal = t => t.AddOffset(TimeZoneInfo.Local.BaseUtcOffset);
        public static Func<DateTimeOffset, DateTimeOffset> localToUtc = t => t.AddOffset(-TimeZoneInfo.Local.BaseUtcOffset);

        #endregion To DateTimeOffset

        #region To DateTime

        /// <summary>
        /// 时间戳转<see cref="DateTime"/>
        /// </summary>
        public static Func<long, DateTime> longToDatetime =>
          ts => TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local)
               + TimeSpan.FromSeconds(ts);

        #endregion To DateTime

        #endregion 基础转换

        #region 组合转换

        public static Func<string, DateTimeOffset> longStringToUtcDateTimeOffset = t => longToUtcDateTimeOffset(stringToLong(t));

        public static Func<string, DateTimeOffset> longStringToLocalDateTimeOffset = t => utcToLocal(longToUtcDateTimeOffset(stringToLong(t)));

        public static Func<string, DateTimeOffset> longStringToUtcDateTimeOffsetByMilliseconds = t => longToUtcDateTimeOffsetByMilliseconds(stringToLong(t));

        public static Func<string, DateTimeOffset> longStringToLocalDateTimeOffsetByMilliseconds = t => utcToLocal(longToUtcDateTimeOffsetByMilliseconds(stringToLong(t)));
        public static Func<string, DateTime> stringToLocalDateTime = t => longToDatetime(stringToLong(t));

        #endregion 组合转换
    }
}