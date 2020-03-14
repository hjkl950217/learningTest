using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        private static void Main(string?[] args)
        {
            //开始验证
            VerificationHelp.StartVerification(VerificationTypeEnum.A24_使用高阶函数, args);
        }
    }
}