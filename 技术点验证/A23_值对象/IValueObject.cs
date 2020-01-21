using Verification.Core;

namespace 技术点验证
{
    public interface IValueObject<TValue>
    {
        /// <summary>
        /// 代表当前值对象对应的值
        /// </summary>
        TValue Value { get; }

        (bool checkResult, BizError errorObj) Check();
    }
}