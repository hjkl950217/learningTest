using Verification.Core;

namespace 技术点验证
{
    /// <summary>
    /// 值对象接口<para></para>
    /// 用于约束值对象的行为规范
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface IValueObject<TValue>
    {
        /// <summary>
        /// 代表当前值对象对应的值
        /// </summary>
        TValue Value { get; }

        (bool checkResult, BizError errorObj) Check();
    }
}