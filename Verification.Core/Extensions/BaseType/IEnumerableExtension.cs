using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class IEnumerableExtension
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

        /// <summary>
        /// foreach的方法版
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void For<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }

        #region Linq方法扩展

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
            source.CheckNull(nameof(source));
            predicate.CheckNull(nameof(predicate));
        }

        private static void CheckArguments(object first, object second, object predicate)
        {
            first.CheckNull(nameof(first));
            second.CheckNull(nameof(second));
            predicate.CheckNull(nameof(predicate));
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

        #endregion Linq方法扩展
    }
}