using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        public static void Main(string[]? args)
        {
            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.A29_模拟中间件_责任链模式, args);
        }
    }
}