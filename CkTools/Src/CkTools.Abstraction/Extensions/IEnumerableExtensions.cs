using System.Linq;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class IEnumerableExtensions
    {
        #region 新加Linq方法

        #region For

        /// <summary>
        /// foreach的方法版
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void For<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
            {
                action(item);
            }
        }

        #endregion For

        #region SelectMap

        /// <summary>
        /// 映射,在原有元素上进行操作<para></para>
        /// 在<see cref="System.Linq.Enumerable.Select{TSource, TResult}(IEnumerable{TSource}, Func{TSource, TResult})"/>基础上封装。<para></para>
        /// 解释：在FP中映射是从一个类型映射到另一个类型，但开发中迫于性能不想产生新的对象而是在原对象上修改，但表达的意思还是映射
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="valueSetter">用于在对象实例上设置值的方法</param>
        /// <returns></returns>
        public static IEnumerable<TSource> SelectMap<TSource>(
            this IEnumerable<TSource> source,
            Action<TSource> valueSetter)
            where TSource : class
        {
            source.CheckNullWithException(nameof(source));
            return source.Select(t => { valueSetter(t); return t; });
        }

        #endregion SelectMap

        #region RemoveNull

        /// <summary>
        /// 移除所有null对象
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> RemoveNull<TSource>(
            this IEnumerable<TSource> source)
        {
            source.CheckNullWithException(nameof(source));
            return source.Where(t => t != null);
        }

        /// <summary>
        /// 移除所有属性为null的对象
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="source"></param>
        /// <param name="propertySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> RemoveNullBy<TSource, TProperty>(
            this IEnumerable<TSource> source,
            Func<TSource, TProperty> propertySelector)
        {
            source.CheckNullWithException(nameof(source));
            propertySelector.CheckNullWithException(nameof(propertySelector));
            return source.Where(t => propertySelector(t) != null);
        }

        /// <summary>
        /// 移除所有null或<see cref="string.Empty"/>对象
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<string> RemoveNullOrEmpty(
            this IEnumerable<string> source)
        {
            source.CheckNullWithException(nameof(source));
            return source.Where(t => !string.IsNullOrEmpty(t));
        }

        /// <summary>
        /// 移除所有属性为null或<see cref="string.Empty"/>的对象
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="propertySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> RemoveNullOrEmptyBy<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, string> propertySelector)
        {
            source.CheckNullWithException(nameof(source));
            propertySelector.CheckNullWithException(nameof(propertySelector));
            return source.Where(t => !string.IsNullOrEmpty(propertySelector(t)));
        }

        #endregion RemoveNull

        #endregion 新加Linq方法

        #region Linq方法扩展

        #region ToArray

        /// <summary>
        /// Select+ToArray的组合版本
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="defaultValue">当<paramref name="source"/>为null时，返回的值.默认值为:0长度的数组</param>
        /// <returns></returns>
        public static TResult[] ToArray<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector,
            TResult[]? defaultValue = null)
        {
            return IEnumerableBaseTo(
                source: source,
                selector: selector,
                converter: Enumerable.ToArray,
                defaultValueFunc: () => defaultValue ?? Array.Empty<TResult>());
        }

        /// <summary>
        /// Select+ToList的组合版本
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="defaultValue">当<paramref name="source"/>为null时，返回的值.默认值为:0长度的<see cref="List{T}"/></param>
        /// <returns></returns>
        public static List<TResult> ToList<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector,
            List<TResult>? defaultValue = null)
        {
            return IEnumerableBaseTo(
                source: source,
                selector: selector,
                converter: Enumerable.ToList,
                defaultValueFunc: () => defaultValue ?? new List<TResult>());
        }

        /// <summary>
        /// Select+ToList的组合版本(异步)
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="defaultValue">当<paramref name="source"/>为null时，返回的值.默认值为:0长度的<see cref="List{T}"/></param>
        /// <returns></returns>
        public static Task<List<TResult>> ToListAsync<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector,
            List<TResult>? defaultValue = null)
        {
            return Task.Run(() =>
            {
                return IEnumerableExtensions.ToList<TSource, TResult>(
                    source: source,
                    selector: selector,
                    defaultValue: defaultValue);
            });
        }

        /// <summary>
        /// 【内部方法】集合接口转具体实现
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TArray"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="converter"></param>
        /// <param name="defaultValueFunc">当<paramref name="source"/>为null时，会调用此委托生成默认值</param>
        /// <returns></returns>
        private static TArray IEnumerableBaseTo<TSource, TResult, TArray>(
          IEnumerable<TSource> source,
          Func<TSource, TResult> selector,
          Func<IEnumerable<TResult>, TArray> converter,
          Func<TArray> defaultValueFunc)
        {
            selector.CheckNullWithException(nameof(selector));

            return source == null
                ? defaultValueFunc()
                : converter(source.Select(selector));
        }

        #endregion ToArray

        #region FirstOrDefault

        public static TSource FirstOrDefault<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate,
            TSource defaultValue)
        {
            IEnumerable<TSource>? temp = source.Where(predicate);
            return temp.Any() ? temp.First() : defaultValue;
        }

        public static TSource FirstOrDefault<TSource>(
            this IEnumerable<TSource> source,
            TSource defaultValue)
        {
            return source.FirstOrDefault() ?? defaultValue;
        }

        #endregion FirstOrDefault

        #endregion Linq方法扩展
    }
}