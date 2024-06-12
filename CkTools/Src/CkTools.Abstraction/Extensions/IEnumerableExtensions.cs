using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CkTools.Abstraction.Comparer;

namespace System.Collections.Generic
{
    public static class IEnumerableExtensions
    {
        #region RedisKey和RedisValue

        //public static IEnumerable<KeyValuePair<string, string>> ToEnumerable(this IEnumerable<KeyValuePair<RedisKey, RedisValue>> keyValuePairs)
        //{
        //    return keyValuePairs
        //        .Select(t => new KeyValuePair<string, string>(t.Key, t.Value));
        //}

        //public static IEnumerable<string> ToEnumerable(this IEnumerable<RedisKey> keyValuePairs)
        //{
        //    return keyValuePairs
        //        .Select(t => (string)t);
        //}

        //public static IEnumerable<string> ToEnumerable(this IEnumerable<RedisValue> keyValuePairs)
        //{
        //    return keyValuePairs
        //        .Select(t => (string)t);
        //}

        //public static IEnumerable<KeyValuePair<RedisKey, RedisValue>> ToRedisEnumerable(this IEnumerable<KeyValuePair<string, string>> keyValuePairs)
        //{
        //    return keyValuePairs
        //        .Select(t => new KeyValuePair<RedisKey, RedisValue>(t.Key, t.Value));
        //}

        //public static IEnumerable<RedisKey> ToRedisKeyEnumerable(this IEnumerable<string> keyValuePairs)
        //{
        //    return keyValuePairs
        //        .Select(t => (RedisKey)t);
        //}

        //public static IEnumerable<RedisValue> ToRedisValueEnumerable(this IEnumerable<string> keyValuePairs)
        //{
        //    return keyValuePairs
        //        .Select(t => (RedisValue)t);
        //}

        #endregion RedisKey和RedisValue

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
            foreach(T item in source)
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

        #region OrderDistinctBy

        /// <summary>
        /// 顺序排序后去重
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TOrderKey"></typeparam>
        /// <typeparam name="TDistinctKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="orderKeySelector"></param>
        /// <param name="distinctKeySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> OrderDistinctBy<TSource, TOrderKey, TDistinctKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TOrderKey> orderKeySelector,
            Func<TSource, TDistinctKey> distinctKeySelector)
        {
            if(source.IsNullOrEmpty())
            {
                yield return default;
            }

            ILookup<TDistinctKey, TSource> lup = source.ToLookup(distinctKeySelector);
            foreach(IGrouping<TDistinctKey, TSource> item in lup)
            {
                yield return item.OrderBy(orderKeySelector).First();
            }
        }

        /// <summary>
        /// 倒序排序后去重
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TOrderKey"></typeparam>
        /// <typeparam name="TDistinctKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="orderKeySelector"></param>
        /// <param name="distinctKeySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> OrderDescDistinctBy<TSource, TOrderKey, TDistinctKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TOrderKey> orderKeySelector,
            Func<TSource, TDistinctKey> distinctKeySelector)
        {
            if(source.IsNullOrEmpty())
            {
                yield return default;
            }

            ILookup<TDistinctKey, TSource> lup = source.ToLookup(distinctKeySelector);
            foreach(IGrouping<TDistinctKey, TSource> item in lup)
            {
                yield return item.OrderByDescending(orderKeySelector).First();
            }
        }

        #endregion OrderDistinctBy

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

        #region WhereIf

        public static IEnumerable<TSource> WhereIf<TSource>(
            this IEnumerable<TSource> source,
            Func<bool> isCondition,
            Func<TSource, bool> predicate)
        {
            return isCondition() ? Enumerable.Where(source, predicate) : source;
        }

        public static IEnumerable<TSource> WhereIf<TSource>(
            this IEnumerable<TSource> source,
            bool isCondition,
            Func<TSource, bool> predicate)
        {
            return IEnumerableExtensions.WhereIf(source, () => isCondition, predicate);
        }

        public static IQueryable<TSource> WhereIf<TSource>(
            this IQueryable<TSource> source,
            Func<bool> isCondition,
            Expression<Func<TSource, bool>> predicate)
        {
            return isCondition() ? Queryable.Where(source, predicate) : source;
        }

        public static IQueryable<TSource> WhereIf<TSource>(
            this IQueryable<TSource> source,
            bool isCondition,
            Expression<Func<TSource, bool>> predicate)
        {
            return IEnumerableExtensions.WhereIf(source, () => isCondition, predicate);
        }

        #endregion WhereIf

        #region JoinString

        /// <summary>
        /// 将对象集合转换成字符串
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source"></param>
        /// <param name="valueFunc"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string JoinString<TSource, TValue>(
            this IEnumerable<TSource> source,
            Func<TSource, TValue> valueFunc,
            string separator = ",")
        {
            if(source == null || !source.Any())
            {
                return string.Empty;
            }

            if(valueFunc is null)
            {
                throw new ArgumentNullException(nameof(valueFunc));
            }

            return string.Join(separator, source.Select(valueFunc));
        }

        #endregion JoinString

        #region SelectIf

        public static IEnumerable<TSource> SelectIf<TSource>(
            this IEnumerable<TSource> source,
             Func<bool> isCondition,
            Func<TSource, TSource> selector)
        {
            return isCondition() ? Enumerable.Select(source, selector) : source;
        }

        public static IEnumerable<TSource> SelectIf<TSource>(
            this IEnumerable<TSource> source,
             bool isCondition,
            Func<TSource, TSource> selector)
        {
            return IEnumerableExtensions.SelectIf(source, () => isCondition, selector);
        }

        public static IQueryable<TSource> SelectIf<TSource>(
            this IQueryable<TSource> source,
            Func<bool> isCondition,
            Expression<Func<TSource, TSource>> selector)
        {
            return isCondition() ? Queryable.Select(source, selector) : source;
        }

        public static IQueryable<TSource> SelectIf<TSource>(
            this IQueryable<TSource> source,
            bool isCondition,
            Expression<Func<TSource, TSource>> selector)
        {
            return IEnumerableExtensions.SelectIf(source, () => isCondition, selector);
        }

        #endregion SelectIf

        #region private check

        /*
         * 致后续维护者：
         *
         * 下面的的linq扩展方法中，参数检查是重复代码。
         * 为了达到控制与逻辑分离的目的,让阅读代码的人少看几行代码，才把这些抽取出来
         *
         * 困难点：1.抛异常时需要把参数名暴露出去 2.逻辑都类似
         *
         * 目前是比较拆中的方案
         */

        private static void CheckArguments(object source, object predicate)
        {
            source.CheckNullWithException(nameof(source));
            predicate.CheckNullWithException(nameof(predicate));
        }

        private static void CheckArguments(object first, object second, object predicate)
        {
            first.CheckNullWithException(nameof(first));
            second.CheckNullWithException(nameof(second));
            predicate.CheckNullWithException(nameof(predicate));
        }

        #endregion private check

        #region Distinct

        /// <summary>
        /// [扩展]使用指定方法比较值，从序列中返回不同的元素。
        /// </summary>
        /// <typeparam name="TSource">source的类型</typeparam>
        /// <param name="source">要删除重复元素的序列</param>
        /// <param name="predicate">用于测试每个元素是否符合的函数</param>
        /// <returns>去重后的<see cref="IEnumerable{T}"/></returns>
        /// <exception cref="ArgumentNullException">参数为null时发生</exception>
        public static IEnumerable<TSource> Distinct<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource, bool> predicate)
            where TSource : class
        {
            CheckArguments(source, predicate);

            return source.Distinct(new EqualComparer<TSource>(predicate));
        }

        /// <summary>
        /// [扩展]使用指定方法比较值，从序列中返回不同的元素。
        /// </summary>
        /// <typeparam name="TSource">source的类型</typeparam>
        /// <param name="source">要删除重复元素的序列</param>
        /// <param name="predicate">用于测试每个元素是否符合的函数,用来判断的属性必须是唯一值</param>
        /// <returns>去重后的<see cref="IEnumerable{T}"/></returns>
        /// <exception cref="ArgumentNullException">参数为null时发生</exception>
        public static IEnumerable<TSource> DistinctBy<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, int> predicate)
            where TSource : class
        {
            CheckArguments(source, predicate);

            return source.Distinct(new HashCodeComparer<TSource>(predicate));
        }

        #endregion Distinct

        #region Except

        /// <summary>
        /// [扩展]使用指定的方法来生成2个序列的差异序列
        /// </summary>
        /// <typeparam name="TSource">source的类型</typeparam>
        /// <param name="first">第一个<see cref="IEnumerable{T}"/>,其元素不在第二个序列中</param>
        /// <param name="second">
        /// 第二个<see cref="IEnumerable{T}"/>,其元素也出现在第一个序列中，这将导致从返回的序列中删除这些元素。
        /// </param>
        /// <param name="predicate">用于测试每个元素是否符合的函数</param>
        /// <returns> </returns>
        /// <exception cref="ArgumentNullException">参数为null时发生</exception>
        public static IEnumerable<TSource> Except<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second,
            Func<TSource, TSource, bool> predicate)
            where TSource : class
        {
            CheckArguments(first, second, predicate);

            return first.Except(second, new EqualComparer<TSource>(predicate));
        }

        /// <summary>
        /// [扩展]使用指定的方法来生成2个序列的差异序列
        /// </summary>
        /// <typeparam name="TSource">source的类型</typeparam>
        /// <param name="first">第一个<see cref="IEnumerable{T}"/>,其元素不在第二个序列中</param>
        /// <param name="second">
        /// 第二个<see cref="IEnumerable{T}"/>,其元素也出现在第一个序列中，这将导致从返回的序列中删除这些元素。
        /// </param>
        /// <param name="predicate">用于测试每个元素是否符合的函数,用来判断的属性必须是唯一值</param>
        /// <returns> </returns>
        /// <exception cref="ArgumentNullException">参数为null时发生</exception>
        public static IEnumerable<TSource> ExceptBy<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second,
            Func<TSource, int> predicate)
            where TSource : class
        {
            CheckArguments(first, second, predicate);

            return first.Except(second, new HashCodeComparer<TSource>(predicate));
        }

        #endregion Except

        #region Intersect

        /// <summary>
        /// [扩展]使用指定的方法来生成2个序列的交集序列
        /// </summary>
        /// <typeparam name="TSource">source的类型</typeparam>
        /// <param name="first">第一个<see cref="IEnumerable{T}"/>,将返回也出现在第二个序列中的元素</param>
        /// <param name="second">第二个<see cref="IEnumerable{T}"/>,将返回也出现在第一个序列中的元素</param>
        /// <param name="predicate">用于测试每个元素是否符合的函数</param>
        /// <returns> </returns>
        /// <exception cref="ArgumentNullException">参数为null时发生</exception>
        public static IEnumerable<TSource> Intersect<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second,
            Func<TSource, TSource, bool> predicate)
            where TSource : class
        {
            CheckArguments(first, second, predicate);

            return first.Intersect(second, new EqualComparer<TSource>(predicate));
        }

        /// <summary>
        /// [扩展]使用指定的方法来生成2个序列的交集序列
        /// </summary>
        /// <typeparam name="TSource">source的类型</typeparam>
        /// <param name="first">第一个<see cref="IEnumerable{T}"/>,将返回也出现在第二个序列中的元素</param>
        /// <param name="second">第二个<see cref="IEnumerable{T}"/>,将返回也出现在第一个序列中的元素</param>
        /// <param name="predicate">用于测试每个元素是否符合的函数,用来判断的属性必须是唯一值</param>
        /// <returns> </returns>
        /// <exception cref="ArgumentNullException">参数为null时发生</exception>
        public static IEnumerable<TSource> IntersectBy<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second,
             Func<TSource, int> predicate)
            where TSource : class
        {
            CheckArguments(first, second, predicate);

            return first.Intersect(second, new HashCodeComparer<TSource>(predicate));
        }

        #endregion Intersect

        #region Any

        /// <summary>
        /// 判断序列是否存在满足条件的元素
        /// </summary>
        /// <param name="source">要判断的序列</param>
        /// <param name="predicate">委托，判断元素是否满足条件</param>
        /// <returns></returns>
        public static bool Any(this IEnumerable source, Func<object?, bool> predicate)
        {
            if(source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if(predicate is null)
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
            return IEnumerableExtensions.Any(source, t => true);
        }

        #endregion Any

        #endregion Linq方法扩展
    }
}