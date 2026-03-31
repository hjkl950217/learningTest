namespace System
{
/// <summary>
/// 提供常用的类型转换委托，可直接作为委托使用或组合使用
/// </summary>
public static partial class TypeConvertDelegate
{
        #region 基础转换

        #region To Long

        /// <summary>
        /// 将 <see cref="string"/> 转换为 <see cref="long"/>
        /// </summary>
        public static Func<string, long> stringToLong = System.Convert.ToInt64;

        #endregion To Long

        #region To Bool

        /// <summary>
        /// int转bool,大于0为true
        /// </summary>
        public static Func<int, bool> intToBool = t => t > 0;

        #endregion To Bool

        #region To DateTimeOffset

        /// <summary>
        /// 将 <see cref="string"/> 解析为 <see cref="DateTimeOffset"/>
        /// </summary>
        public static Func<string, DateTimeOffset> stringToDateTimeOffset = DateTimeOffset.Parse;
        /// <summary>
        /// 将 Unix 时间戳（秒）转换为 UTC 的 <see cref="DateTimeOffset"/>
        /// </summary>
        public static Func<long, DateTimeOffset> longToUtcDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds;
        /// <summary>
        /// 将 Unix 时间戳（毫秒）转换为 UTC 的 <see cref="DateTimeOffset"/>
        /// </summary>
        public static Func<long, DateTimeOffset> longToUtcDateTimeOffsetByMilliseconds = DateTimeOffset.FromUnixTimeMilliseconds;
        /// <summary>
        /// 将 UTC 时间的 <see cref="DateTimeOffset"/> 转换为本地时间
        /// </summary>
        public static Func<DateTimeOffset, DateTimeOffset> utcToLocal = t => t.AddOffset(TimeZoneInfo.Local.BaseUtcOffset);
        /// <summary>
        /// 将本地时间的 <see cref="DateTimeOffset"/> 转换为 UTC 时间
        /// </summary>
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

        /// <summary>
        /// 将表示 Unix 时间戳（秒）的 <see cref="string"/> 转换为 UTC 的 <see cref="DateTimeOffset"/>
        /// </summary>
        public static Func<string, DateTimeOffset> longStringToUtcDateTimeOffset = t => longToUtcDateTimeOffset(stringToLong(t));

        /// <summary>
        /// 将表示 Unix 时间戳（秒）的 <see cref="string"/> 转换为本地时间的 <see cref="DateTimeOffset"/>
        /// </summary>
        public static Func<string, DateTimeOffset> longStringToLocalDateTimeOffset = t => utcToLocal(longToUtcDateTimeOffset(stringToLong(t)));

        /// <summary>
        /// 将表示 Unix 时间戳（毫秒）的 <see cref="string"/> 转换为 UTC 的 <see cref="DateTimeOffset"/>
        /// </summary>
        public static Func<string, DateTimeOffset> longStringToUtcDateTimeOffsetByMilliseconds = t => longToUtcDateTimeOffsetByMilliseconds(stringToLong(t));

        /// <summary>
        /// 将表示 Unix 时间戳（毫秒）的 <see cref="string"/> 转换为本地时间的 <see cref="DateTimeOffset"/>
        /// </summary>
        public static Func<string, DateTimeOffset> longStringToLocalDateTimeOffsetByMilliseconds = t => utcToLocal(longToUtcDateTimeOffsetByMilliseconds(stringToLong(t)));
        /// <summary>
        /// 将表示 Unix 时间戳（秒）的 <see cref="string"/> 转换为本地 <see cref="DateTime"/>
        /// </summary>
        public static Func<string, DateTime> stringToLocalDateTime = t => longToDatetime(stringToLong(t));

        #endregion 组合转换
    }
}