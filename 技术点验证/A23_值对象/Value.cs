namespace 技术点验证
{
    /// <summary>
    /// 值对象-针对值类型<para></para>
    /// 针对<see cref="string"/>:不能为null或<see cref="string.Empty"/><para></para>
    /// 针对其它值类型：没有限制
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <remarks>
    /// 这个类也可以不要，因为它只处理了string的情况。但为了风格统一，我依然保留了它，反正<![CDATA[value<int>]]>也不会报错233.
    /// </remarks>
    public sealed class Value<TValue> : ValueBase<TValue>
    {
        private readonly bool isString = false;

        public Value(TValue data) : base(data)
        {
            this.isString = typeof(TValue) == typeof(string);
        }

        public override bool BizCheckValue()
        {
            return this.isString
                ? !string.IsNullOrEmpty(base.Value as string) //string类型不能为null或""
                : true;//其它值类型不存在异常情况。如：int=0 也是允许的
        }
    }
}