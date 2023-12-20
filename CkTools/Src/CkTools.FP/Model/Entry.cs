namespace CkTools.FP.Model
{
    /// <summary>
    /// 条目-用于带顺序的存储数据
    /// </summary>
    public struct Entry
    {
        #region 静态方法

        /// <summary>
        /// 创建<see cref="Entry{T}"/>
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="value">值</param>
        public static Entry<T?> Create<T>(int index, T? value)
        {
            return new Entry<T?>(index, value);
        }

        #endregion 静态方法
    }
}