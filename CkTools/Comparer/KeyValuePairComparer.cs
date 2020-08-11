using System;
using System.Collections.Generic;

namespace CkTools.Comparer
{
    /// <summary>
    /// <see cref="KeyValuePair{TKey, TValue}"/> 比较器.默认按<see cref="KeyValuePair{TKey, TValue}.Key"/>比较.使用时需要自己处理null的情况
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class KeyValuePairComparer<TKey, TValue> : EqualityComparer<KeyValuePair<TKey, TValue>>
    {
        private readonly Func<KeyValuePair<TKey, TValue>, KeyValuePair<TKey, TValue>, bool> equalsFunc = null;

        /// <summary>
        /// 初始化一个<see cref="KeyValuePairComparer{TKey, TValue}"/>实例
        /// </summary>
        /// <param name="equalsFunc">默认使用key比较，传递此参数后，会使用比较方法比较。</param>
        public KeyValuePairComparer(
            Func<KeyValuePair<TKey, TValue>, KeyValuePair<TKey, TValue>, bool> equalsFunc = null)
        {
            this.equalsFunc = equalsFunc;
        }

        public override bool Equals(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
        {
            return this.equalsFunc(x, y);
        }

        public override int GetHashCode(KeyValuePair<TKey, TValue> obj)
        {
            if (this.equalsFunc == null)
            {
                return obj.Key.GetHashCode();
            }
            else
            {
                return 0;//这里写0是为了让框架调用到Equals比较方法
            }
        }
    }
}