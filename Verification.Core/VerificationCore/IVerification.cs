namespace Verification.Core
{
    /// <summary>
    /// 验证想法的接口
    /// </summary>
    public interface IVerification
    {
        /// <summary>
        /// 开始验证
        /// </summary>
        /// <param name="args">启动时，传递给main方法的args</param>
        void Start(string[] args);
    }
}