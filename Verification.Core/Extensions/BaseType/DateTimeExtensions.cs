namespace System
{
    /// <summary>
    /// DateTime扩展类
    /// </summary>
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 获取Unix时间戳,单位为秒（前端默认是s）
        /// </summary>
        /// <param name="source"></param>
        /// <remarks>从1970-01-01T00:00:00.000Z到现在的时间戳</remarks>
        /// <returns></returns>
        public static long GetUnixTimestamp(this DateTime source)
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
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


    }

}