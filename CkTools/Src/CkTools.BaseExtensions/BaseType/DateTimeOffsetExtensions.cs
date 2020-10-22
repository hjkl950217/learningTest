namespace System
{
    /// <summary>
    /// <see cref="DateTimeOffset"/>的扩展类
    /// </summary>
    public static class DateTimeOffsetExtensions
    {
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
            return new DateTimeOffset(source.UtcDateTime.Ticks, source.Offset + offset);
        }
    }
}