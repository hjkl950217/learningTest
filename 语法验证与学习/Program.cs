using Verification.Core;
using Verification.Core.VerificationCore;

namespace 语法验证与学习
{
    public class Program
    {
        public static void Main(string[]? args)
        {
            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.B17_Aggregate, args);
        }
    }
}