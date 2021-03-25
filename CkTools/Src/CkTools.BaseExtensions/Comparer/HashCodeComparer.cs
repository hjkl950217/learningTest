using System;
using System.Collections.Generic;

namespace CkTools.BaseExtensions.Comparer
{
    /// <summary>
    /// 使用 HashCode 进行比较，适用于简单场景或性能要求极高场景
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HashCodeComparer<T> : EqualityComparer<T>
        where T : class
    {
        private readonly Func<T, int> hashFunc;

        public HashCodeComparer(Func<T, int> hashFunc)
        {
            this.hashFunc = hashFunc;
        }

        public override bool Equals(T x, T y)
        {
            return true;
        }

        public override int GetHashCode(T obj)
        {
            return this.hashFunc(obj);
        }
    }
}