using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace System.Collections.Generic
{
    public static class DictionaryExtension
    {
        public static TValue GetOrAdd<TKey, TValue>(
            this IDictionary<TKey, TValue> valuePairs,
            TKey key,
            Func<TValue> valueFactory)
        {
            if (valueFactory == null) throw new ArgumentNullException(nameof(valueFactory));

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
    }
}
