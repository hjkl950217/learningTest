using System;

namespace CkTools.Helper
{
    /// <summary>
    /// DateTime 帮助类
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// 获取Unix时间戳,单位为秒（前端默认是s）
        /// </summary>
        /// <param name="isUtc">是否从UTC时间开始计算,传递flase时使用本地时区进行计算</param>
        /// <remarks>从1970-01-01T00:00:00.000Z到现在的时间戳</remarks>
        /// <returns></returns>
        public static long GetUnixTimestamp(bool isUtc = true)
        {
            return DateTimeOffsetExtensions.GetUnixTimestamp(DateTimeOffset.Now, isUtc);
        }

        /// <summary>
        /// 获取Unix时间戳,单位为毫秒
        /// </summary>
        /// <param name="isUtc">是否从UTC时间开始计算,传递flase时使用本地时区进行计算</param>
        /// <remarks>从1970-01-01T00:00:00.000Z到现在的时间戳</remarks>
        /// <returns></returns>
        public static long GetMilliUnixTimestamp(bool isUtc = true)
        {
            return DateTimeOffsetExtensions.GetMilliUnixTimestamp(DateTimeOffset.Now, isUtc);
        }
    }
}