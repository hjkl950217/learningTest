using System.Collections.Generic;

namespace CkTools.FP.Model
{
    /// <summary>
    /// 条目-用于带顺序的存储数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct Entry<T>
    {
        /// <summary>
        /// 索引值
        /// </summary>
        public int Index;

        /// <summary>
        /// 值
        /// </summary>
        public T Value;

        /// <summary>
        /// 初始化<see cref="Entry"/>
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="value">值</param>
        internal Entry(int index, T value)
        {
            this.Index = index;
            this.Value = value;
        }

        public static implicit operator Entry<T?>(T? entry)
        {
            return Entry.Create(0, entry);
        }

        public static implicit operator Entry<T?>((int, T?) entry)
        {
            return Entry.Create(entry.Item1, entry.Item2);
        }

        public static bool operator ==(Entry<T> left, Entry<T> right)
        {
            return Comparer<T>.Default.Compare(left.Value, right.Value) == 0;
        }

        public static bool operator !=(Entry<T> left, Entry<T> right)
        {
            return !(left == right);
        }

        public static bool operator ==(Entry<T> left, T right)
        {
            return Comparer<T>.Default.Compare(left.Value, right) == 0;
        }

        public static bool operator !=(Entry<T> left, T right)
        {
            return !(left == right);
        }
    }
}