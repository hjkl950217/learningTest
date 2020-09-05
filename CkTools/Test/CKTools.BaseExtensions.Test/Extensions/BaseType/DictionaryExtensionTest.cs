using CkTools.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace CKTools.BaseExtensions.Test.Extensions.BaseType
{
    public class DictionaryExtensionTest
    {
        public class ToReadOnlyTest
        {
            [Fact]
            public void Dictionary()
            {
                var source = TestHelper.Mock<Dictionary<int, int>>();

                IReadOnlyDictionary<int, int> result = source.ToReadOnly();

                Assert.Equal(source.GetHashCode(), result.GetHashCode());
            }

            [Fact]
            public void ReadOnlyDictionary()
            {
                var source = TestHelper.Mock<ReadOnlyDictionary<int, int>>();

                IReadOnlyDictionary<int, int> result = source.ToReadOnly();

                Assert.Equal(source.GetHashCode(), result.GetHashCode());
            }

            [Fact]
            public void TestArray()
            {
                var source = TestHelper.MockArray<KeyValuePair<int, int>>(5);

                IReadOnlyDictionary<int, int> result = source.ToReadOnly();

                Assert.NotEqual(source.GetHashCode(), result.GetHashCode());
            }

            [Fact]
            public void TestDictionary()
            {
                var source = TestHelper.Mock<TestDictionary<int, int>>();

                IReadOnlyDictionary<int, int> result = source.ToReadOnly();

                Assert.NotEqual(source.GetHashCode(), result.GetHashCode());
            }
        }
    }

    public class TestDictionary<TKey, TValue> : IDictionary<TKey, TValue>
        where TKey : notnull
    {
        public Dictionary<TKey, TValue> InternelDic { get; set; }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys { get; }

        ICollection<TValue> IDictionary<TKey, TValue>.Values { get; }

        int ICollection<KeyValuePair<TKey, TValue>>.Count { get; }

        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly { get; }

        TValue IDictionary<TKey, TValue>.this[TKey key]
        {
            get => default;
            set { }
        }

        void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
        {
            this.InternelDic.Add(key, value);
        }

        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
        {
            (this.InternelDic as ICollection<KeyValuePair<TKey, TValue>>)?.Add(item);
        }

        void ICollection<KeyValuePair<TKey, TValue>>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
        {
            return (this.InternelDic as IEnumerable<KeyValuePair<TKey, TValue>>)?.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this.InternelDic as IEnumerable)?.GetEnumerator();
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }
    }
}