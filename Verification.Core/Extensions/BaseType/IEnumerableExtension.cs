using System.Collections.Generic;

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
    }
}