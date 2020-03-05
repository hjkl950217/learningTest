using System.Linq;

namespace System.Collections.Generic
{
    public static class DictionaryExtension
    {
        public static TValue GetOrAdd<TKey, TValue>(
            this IDictionary<TKey, TValue> valuePairs,
            TKey key,
            Func<TValue> valueFactory)
            where TKey : notnull
        {
            valuePairs.CheckNull(nameof(valuePairs));
            valueFactory.CheckNull(nameof(valueFactory));

            bool isExist = valuePairs.TryGetValue(key, out TValue value);

            if (isExist) { return value; }
            else
            {
                var tempValue = valueFactory();
                valuePairs.Add(key, tempValue);
                return tempValue;
            }
        }
    }

    public static class ICollectionExtension
    {
        public static T GetOrAdd<T>(
            this ICollection<T> source,
            Func<T, bool> predicate,
            Func<T> valueFactory)
            where T : class
        {
            source.CheckNull(nameof(source));
            predicate.CheckNull(nameof(predicate));
            valueFactory.CheckNull(nameof(valueFactory));

            T value = source.FirstOrDefault(predicate);
            if (value == null)
            {
                var tempValue = valueFactory();
                source.Add(tempValue);
                return tempValue;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 浅拷贝到另一个数组中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">要拷贝的数据源</param>
        /// <param name="size">指定的数组大小</param>
        /// <returns></returns>
        public static T[] Copy<T>(this ICollection<T> source, int size)
        {
            source.CheckNull(nameof(source));

            T[] tempResult = new T[size];
            source.CopyTo(tempResult, 0);
            return tempResult;
        }

        /// <summary>
        /// 浅拷贝到另一个数组中,默认数组大小为<see cref="ICollection{T}.Count"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">要拷贝的数据源</param>
        /// <returns></returns>
        public static T[] Copy<T>(this ICollection<T> source)
        {
            source.CheckNull(nameof(source));
            return source.Copy(source.Count);
        }
    }
}