﻿namespace CkTools.FP.Model
{
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

        public static implicit operator Entry<T>((int, T) entry)
        {
            return Entry.Create(entry.Item1, entry.Item2);
        }
    }
}