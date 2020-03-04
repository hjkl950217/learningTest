using Verification.Core;

namespace 语法验证与学习
{
    public class Program
    {
        private static void Main(string?[] args)
        {
            //开始验证
            VerificationHelp.StartVerification(VerificationTypeEnum.B16_NotNull特性_80, args);
        }
    }
}