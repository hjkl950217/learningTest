using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        public static void Main(string?[] args)
        {
            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.A26_不同集合的对比纪录, args);
        }
    }
}