using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace System.Collections.Generic
{
    /// <summary>
    /// Dictionary扩展类
    /// </summary>
    public static class DictionaryExtensions
    {
        [return: MaybeNull]
        public static TValue GetOrDefault<TKey, TValue>(
            this IDictionary<TKey, TValue> valuePairs,
            TKey key,
            TValue defaultValue = default)
        {
            if(valuePairs.IsNullOrEmpty())
            { return defaultValue; }

            bool isExist = valuePairs.TryGetValue(key, out TValue value);
            if(isExist)
            { return value; }
            else
            { return defaultValue; }
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
            valuePairs.CheckNullWithException(nameof(valuePairs));

            bool isExist = valuePairs.ContainsKey(key);
            if(!isExist)
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
            if(valuePairs.IsNullOrEmpty())
            {
                return string.Empty;
            }

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
            valuePairs.CheckNullWithException(nameof(valuePairs));
            factory.CheckNullWithException(nameof(factory));

            bool isExist = valuePairs.TryGetValue(key, out TValue value);
            if(isExist)
            { return value; }
            else
            {
                TValue result = factory();
                lock(valuePairs)
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
        /// 当key不存在时调用<paramref name="updateFunc"/>获取一个新值并添加到<paramref name="valuePairs"/>中
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <param name="updateFunc">一个委托,指示如何更新。存在时传递旧值给委托,不存在时传递<see cref="default"/>给委托</param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(
           this IDictionary<TKey, TValue> valuePairs,
           TKey key,
           Func<TValue, TValue> updateFunc,
            TValue defaultValue = default)
        {
            valuePairs.CheckNullWithException(nameof(valuePairs));
            updateFunc.CheckNullWithException(nameof(updateFunc));

            TValue value;
            if(valuePairs.ContainsKey(key))
            {
                value = valuePairs[key];
                value = updateFunc(value);
                valuePairs[key] = value;
            }
            else
            {
                value = updateFunc(defaultValue);
                valuePairs.Add(key, value);
            }

            return value;
        }

        /// <summary>
        /// 添加或更新一个值.<para></para>
        /// 当key不存在时将<paramref name="value"/>添加到<paramref name="valuePairs"/>中
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="valuePairs"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(
           this IDictionary<TKey, TValue> valuePairs,
           TKey key,
           TValue value)
        {
            valuePairs.CheckNullWithException(nameof(valuePairs));

            return valuePairs.AddOrUpdate(key, t => value);
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
            return valuePairs.AddOrUpdate(key, t => factory());
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