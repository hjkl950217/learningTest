namespace CkTools.FP.Model
{
    /// <summary>
    /// 条目
    /// </summary>
    public struct Entry
    {
        /// <summary>
        /// 索引值
        /// </summary>
        public int Index;

        /// <summary>
        /// 值
        /// </summary>
        public object Value;

        /// <summary>
        /// 初始化<see cref="Entry"/>
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="value">值</param>
        private Entry(int index, object value)
        {
            this.Index = index;
            this.Value = value;
        }

        #region 静态方法

        /// <summary>
        /// 创建<see cref="Entry"/>
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="value">值</param>
        public static Entry Create(int index, object value)
        {
            return new Entry(index, value);
        }

        /// <summary>
        /// 创建<see cref="Entry{T}"/>
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="value">值</param>
        public static Entry<T> Create<T>(int index, T value)
        {
            return new Entry<T>(index, value);
        }

        #endregion 静态方法

        public static implicit operator Entry((int, object) entry)
        {
            return Entry.Create(entry.Item1, entry.Item2);
        }
    }
}