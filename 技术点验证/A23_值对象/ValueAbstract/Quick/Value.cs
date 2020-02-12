using System;

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
        /// <summary>
        /// 如果为true，代表检查时调用string.IsNullOrEmpty()方法判断，不能为null或""
        /// 如果为false,永远为true.
        /// </summary>
        private readonly bool isString = false;

        public Value(TValue data) : base(data)
        {
            Type type = typeof(TValue);
            if (type.IsClass && type != typeof(string))//保证进来的是值类型或是string
            {
                throw new TypeAccessException($"只接受所有struct和string,收到的类型为：{type.Name}");
            }

            this.isString = type == typeof(string);
        }

        public override bool BizCheckValue()
        {
            return this.isString
                ? !string.IsNullOrEmpty(base.Value as string)
                : true;
        }
    }
}