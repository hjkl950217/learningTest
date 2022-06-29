using Verification.Core.VerificationCore;

namespace 技术点验证
{
    public class Program
    {
        public static void Main(string[]? args)
        {
            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.A44_Barrier同步基元的使用示例, args);
        }
    }
}