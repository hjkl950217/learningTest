using System;
using System.Collections.Generic;

namespace CkTools.BaseExtensions.Comparer
{
    /// <summary>
    /// 使用 逻辑 进行比较，适用于一般场景
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EqualComparer<T> : EqualityComparer<T>
        where T : class
    {
        private readonly Func<T, T, bool> equalFunc;

        public EqualComparer(Func<T, T, bool> equalFunc)
        {
            this.equalFunc = equalFunc;
        }

        public override bool Equals(T x, T y)
        {
            return this.equalFunc(x, y);
        }

        public override int GetHashCode(T obj)
        {
            return 1;
        }
    }
}