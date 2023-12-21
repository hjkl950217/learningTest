namespace System.Collections
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// 判断序列是否存在满足条件的元素
        /// </summary>
        /// <param name="source">要判断的序列</param>
        /// <param name="predicate">委托，判断元素是否满足条件</param>
        /// <returns></returns>
        public static bool Any(this IEnumerable source, Func<object?, bool> predicate)
        {
            if(source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if(predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            foreach(object? item in source)
            {
                if(predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 判断序列是否存在满足条件的元素
        /// </summary>
        /// <param name="source">要判断的序列</param>
        /// <returns></returns>
        public static bool Any(this IEnumerable source)
        {
            if(source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return Any(source, t => true);
        }
    }
}