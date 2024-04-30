using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class ICollectionExtensions
    {
        public static T GetOrAdd<T>(
            this ICollection<T> source,
            Func<T, bool> predicate,
            Func<T> valueFactory)
            where T : class
        {
            source.CheckNullWithException(nameof(source));
            predicate.CheckNullWithException(nameof(predicate));
            valueFactory.CheckNullWithException(nameof(valueFactory));

            T value = source.FirstOrDefault(predicate);
            switch(value)
            {
                case null:
                {
                    T tempValue = valueFactory();
                    source.Add(tempValue);
                    return tempValue;
                }

                default:
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
            source.CheckNullWithException(nameof(source));

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
            source.CheckNullWithException(nameof(source));
            return source.Copy(source.Count);
        }
    }
}