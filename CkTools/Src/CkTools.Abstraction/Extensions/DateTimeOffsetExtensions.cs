namespace System
{
    /// <summary>
    /// <see cref="DateTimeOffset"/>的扩展类
    /// </summary>
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取Unix时间戳,单位为秒（前端默认是s）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="isUtc">是否从UTC时间开始计算,传递flase时使用本地时区进行计算</param>
        /// <remarks>从1970-01-01T00:00:00.000Z到现在的时间戳</remarks>
        /// <returns></returns>
        public static long GetUnixTimestamp(this DateTimeOffset source, bool isUtc = true)
        {
            return (isUtc ? DateTimeOffset.UtcNow : DateTimeOffset.Now).ToUnixTimeSeconds();
        }

        /// <summary>
        /// 获取Unix时间戳,单位为毫秒
        /// </summary>
        /// <param name="source"></param>
        /// <param name="isUtc">是否从UTC时间开始计算</param>
        /// <remarks>从1970-01-01T00:00:00.000Z到现在的时间戳,传递flase时使用本地时区进行计算</remarks>
        /// <returns></returns>
        public static long GetMilliUnixTimestamp(this DateTimeOffset source, bool isUtc = true)
        {
            return (isUtc ? DateTimeOffset.UtcNow : DateTimeOffset.Now).ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// 转换为Unix时间戳,单位为秒（前端默认是s）
        /// </summary>
        /// <param name="source"></param>
        /// <remarks>建议传递格林威治时间,从1970-01-01T00:00:00.000Z到现在的时间戳</remarks>
        /// <returns></returns>
        public static long ToUnixTimestamp(this DateTimeOffset source)
        {
            return source.ToUnixTimeSeconds();
        }

        /// <summary>
        /// 在当前时间上面添加偏移
        /// </summary>
        /// <param name="source"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static DateTimeOffset AddOffset(this DateTimeOffset source, TimeSpan offset)
        {
            return new DateTimeOffset(source.UtcDateTime.Ticks + offset.Ticks, source.Offset + offset);
        }
    }
}