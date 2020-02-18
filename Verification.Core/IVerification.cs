namespace Verification.Core
{
    /// <summary>
    /// 验证想法的接口
    /// </summary>
    public interface IVerification
    {
        /// <summary>
        /// 验证的类型
        /// </summary>
        VerificationTypeEnum VerificationType { get; }

        /// <summary>
        /// 开始验证
        /// </summary>
        /// <param name="args">启动时，传递给main方法的args</param>
        void Start(string[] args);
    }
}