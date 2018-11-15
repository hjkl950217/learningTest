namespace Verification.Core
{
    /// <summary>
    /// 验证想法的接口
    /// </summary>
    public interface IVerification
    {
        VerificationTypeEnum VerificationType { get;}

        /// <summary>
        /// 开始验证
        /// </summary>
        void Start(string[] args);
    }
}