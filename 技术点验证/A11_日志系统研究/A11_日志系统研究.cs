using Verification.Core;

namespace 技术点验证
{
    /*
     * 需要
     * Microsoft.Extensions.Logging.Abstractions
     * Microsoft.Extensions.Logging
     * Microsoft.Extensions.DependencyInjection.Abstractions
     */

    [VerifcationType(VerificationTypeEnum.A11_日志系统研究)]
#pragma warning disable S101 // Types should be named in PascalCase
    public class A11_日志系统研究 : IVerification
#pragma warning restore S101 // Types should be named in PascalCase
    {
        public VerificationTypeEnum VerificationType =>
            VerificationTypeEnum.A11_日志系统研究;

        public void Start(string?[] args)
        {
        }
    }
}