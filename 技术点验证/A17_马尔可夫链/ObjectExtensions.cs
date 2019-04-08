using System.Collections;

namespace System
{
    /// <summary>
    /// Object extension functions
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// 检查参数是否为null，为null时抛出异常
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj"/>为null时抛出</exception>
        public static void CheckNull<T>(this T obj, string paramName)
        {
            if (obj == null) throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// 检查参数是否为null，为null时抛出异常
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <param name="message">抛出异常时,显示的错误信息</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj"/>为null时抛出</exception>
        public static void CheckNull<T>(this T obj, string paramName, string message)
        {
            if (obj == null) throw new ArgumentNullException(paramName, message);
        }

        /// <summary>
        /// 检查参数是否为null或emtpy，为null或emtpy时抛出异常
        /// </summary>
        /// <param name="obj">要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj"/>为null或emtpy时抛出</exception>
        public static void CheckNullOrEmpty(this IEnumerable obj, string paramName)
        {
            if (obj.IsNullOrEmpty()) throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// 检查参数是否为null或emtpy，为null或emtpy时抛出异常
        /// </summary>
        /// <param name="obj">要检查的对象</param>
        /// <param name="paramName">抛出异常时,显示的参数名</param>
        /// <param name="message">抛出异常时,显示的错误信息</param>
        /// <exception cref="ArgumentNullException"><paramref name="obj"/>为null或emtpy时抛出</exception>
        public static void CheckNullOrEmpty(this IEnumerable obj, string paramName, string message)
        {
            if (obj.IsNullOrEmpty()) throw new ArgumentNullException(paramName, message);
        }
    }
}