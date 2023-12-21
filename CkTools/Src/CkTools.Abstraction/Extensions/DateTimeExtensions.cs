namespace System
{
    /// <summary>
    /// <see cref="DateTime"/>扩展类
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 获取Unix时间戳,单位为秒（前端默认是s）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="isUtc">是否从UTC时间开始计算,传递flase时使用本地时区进行计算</param>
        /// <remarks>从1970-01-01T00:00:00.000Z到现在的时间戳</remarks>
        /// <returns></returns>
        public static long GetUnixTimestamp(this DateTime source, bool isUtc = true)
        {
            //return (isUtc ? DateTimeOffset.UtcNow : DateTimeOffset.Now).ToUnixTimeSeconds();
            return DateTimeOffsetExtensions.GetUnixTimestamp(source, isUtc);
        }

        /// <summary>
        /// 获取Unix时间戳,单位为毫秒
        /// </summary>
        /// <param name="source"></param>
        /// <param name="isUtc">是否从UTC时间开始计算</param>
        /// <remarks>从1970-01-01T00:00:00.000Z到现在的时间戳,传递flase时使用本地时区进行计算</remarks>
        /// <returns></returns>
        public static long GetMilliUnixTimestamp(this DateTime source, bool isUtc = true)
        {
            //return (isUtc ? DateTimeOffset.UtcNow : DateTimeOffset.Now).ToUnixTimeMilliseconds();
            return DateTimeOffsetExtensions.GetMilliUnixTimestamp(source, isUtc);
        }

        /// <summary>
        /// 获取时间片段的字符串(默认：X时X分X秒)
        /// </summary>
        /// <param name="endTime">结束时间</param>
        /// <param name="stratTime">开始时间</param>
        /// <param name="format">格式化方法.入参: 总时、总分、总秒</param>
        /// <returns></returns>
        public static string GetTimeSpan(
            this DateTime endTime,
            DateTime stratTime,
            Func<int, int, int, string>? format = null)
        {
            if(format == null)
            {
                format = (hours, minutes, seconds) => $"{hours}时{minutes}分{seconds}秒";
            }

            System.TimeSpan ts = endTime - stratTime;
            int hourNum = (ts.Days * 24) + ts.Hours;
            int minuteNum = ts.Minutes % 60;
            int secondNum = ts.Seconds % 3600;

            return format(hourNum, minuteNum, secondNum);
        }

        /// <summary>
        /// 在当前时间上面添加偏移
        /// </summary>
        /// <param name="source"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static DateTimeOffset AddOffset(this DateTime source, TimeSpan offset)
        {
            return source.Add(offset);
        }
    }
}