namespace System.Collections.Concurrent
{
    public static class ConcurrentDictionaryExtensions
    {
        public static TValue GetOrAddFirstTry<TKey, TValue>(
            this ConcurrentDictionary<TKey, TValue> dictionary,
            TKey key,
            TValue newValue) where TValue : class
        {
            if (dictionary.TryGetValue(key, out TValue value))
            {
                return value;
            }
            else
            {
                return dictionary.GetOrAdd(key, newValue);
            }
        }
    }
}