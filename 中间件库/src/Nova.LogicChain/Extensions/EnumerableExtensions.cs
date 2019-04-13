using System.Collections;

namespace System.Linq
{
    public static class EnumerableExtensions
    {
        #region 检查null或empty

        /// <summary>
        /// 检查null或Empty
        /// <para>为null或Empty时返回true</para>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this IEnumerable source)
        {
            return !source.IsNotNullOrEmpty();
        }

        /// <summary>
        /// 检查null或Empty
        /// <para>为null或Empty时返回false</para>
        /// </summary>
        public static bool IsNotNullOrEmpty(this IEnumerable source)
        {
            return (source?.GetEnumerator()?.MoveNext()).GetValueOrDefault();
        }

        #endregion 检查null或empty
    }
}