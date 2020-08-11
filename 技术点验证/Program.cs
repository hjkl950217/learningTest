using Verification.Core;
using Verification.Core.VerificationCore;

namespace 技术点验证
{
    public class Program
    {
        public static void Main(string[]? args)
        {
            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.A31_快速转换枚举为字典, args);
        }
    }
}