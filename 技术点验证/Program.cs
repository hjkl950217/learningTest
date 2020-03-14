using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        public static void Main(string?[] args)
        {
            //开始验证
            VerificationHelp.StartVerification(VerificationTypeEnum.A25_查看调用者信息, args);
        }
    }
}