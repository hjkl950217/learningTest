using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace System
{
    /// <summary>
    /// Dictionary扩展类
    /// </summary>
    public static class DictionaryExtensions
    {
        public static TValue GetOrDefault<TKey, TValue>(
            this IDictionary<TKey, TValue> valuePairs,
            TKey key,
            TValue defaultValue = default)
        {
            key.CheckNullWithException(nameof(key));
            if (valuePairs.IsNullOrEmpty()) { return defaultValue; }

            bool isExist = valuePairs.TryGetValue(key, out TValue value);
            if (isExist) { return value; }
            else { return defaultValue; }
        }

        /// <summary>
        /// 尝试向<paramref name="valuePairs"/>中添加新key。如果已经存在相同的key,则不会添加
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns>true，添加成功。否则false</returns>
        public static bool TryAdd<TKey, TValue>(
            this IDictionary<TKey, TValue> valuePairs,
             TKey key,
             TValue value)
        {
            key.CheckNullWithException(nameof(key));
            value.CheckNullWithException(nameof(value));
            valuePairs.CheckNullWithException(nameof(valuePairs));

            bool isExist = valuePairs.ContainsKey(key);
            if (!isExist)
            {
                valuePairs.Add(key, value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 连接key.<paramref name="valuePairs"/>为null时返回<see cref="string.Empty"/>
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <returns></returns>
        public static string ConcatKey<TKey, TValue>(
            this IEnumerable<KeyValuePair<TKey, TValue>> valuePairs)
        {
            if (valuePairs.IsNullOrEmpty()) return string.Empty;

            return string.Concat(valuePairs.Select(t => t.Key));
        }

        /// <summary>
        /// 获取或添加
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static TValue GetOrAdd<TKey, TValue>(
            this IDictionary<TKey, TValue> valuePairs,
            TKey key,
            Func<TValue> factory)

        {
            key.CheckNullWithException(nameof(key));
            valuePairs.CheckNullWithException(nameof(valuePairs));
            factory.CheckNullWithException(nameof(factory));

            bool isExist = valuePairs.TryGetValue(key, out TValue value);
            if (isExist) { return value; }
            else
            {
                TValue result = factory();
                lock (valuePairs)
                {
                    valuePairs.Add(key, result);
                }
                return result;
            }
        }

        /// <summary>
        /// 获取或添加一个默认值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue GetOrAddNew<TKey, TValue>(
           this IDictionary<TKey, TValue> valuePairs,
           TKey key)
            where TValue : new()
        {
            return valuePairs.GetOrAdd(key, () => new TValue());
        }

        /// <summary>
        /// 获取或添加一个默认值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static TValue GetOrAddNew<TKey, TValue>(
           this IDictionary<TKey, TValue> valuePairs,
           TKey key,
           Func<TValue> factory)

        {
            factory.CheckNullWithException(nameof(factory));
            return valuePairs.GetOrAdd(key, () => factory());
        }

        /// <summary>
        /// 添加或更新一个值.<para></para>
        /// 当key不存在时调用<paramref name="factory"/>获取一个新值并添加到<paramref name="valuePairs"/>中
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(
           this IDictionary<TKey, TValue> valuePairs,
           TKey key,
           Func<TValue> factory)
        {
            return valuePairs.AddOrUpdate(key, factory);
        }

        /// <summary>
        /// 添加或更新一个值.<para></para>
        /// 当key不存在时将<paramref name="value"/>添加到<paramref name="valuePairs"/>中
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(
           this IDictionary<TKey, TValue> valuePairs,
           TKey key,
           TValue value)
        {
            valuePairs.CheckNullWithException(nameof(valuePairs));
            value.CheckNullWithException(nameof(value));

            if (valuePairs.ContainsKey(key))
            {
                valuePairs[key] = value;
            }
            else
            {
                valuePairs.Add(key, value);
            }

            return value;
        }

        public static IReadOnlyDictionary<TKey, TValue> ToReadOnly<TKey, TValue>(
            this IEnumerable<KeyValuePair<TKey, TValue>> source)
        {
            source.CheckNullOrEmptyWithException(nameof(source));

            return source switch
            {
                IReadOnlyDictionary<TKey, TValue> rod => (IReadOnlyDictionary<TKey, TValue>)source,
                IDictionary<TKey, TValue> dic => new ReadOnlyDictionary<TKey, TValue>(dic),
                _ => new ReadOnlyDictionary<TKey, TValue>(source.ToDictionary(k => k.Key, v => v.Value)),
            };
        }
    }
}