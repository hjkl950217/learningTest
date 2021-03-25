using Verification.Core;
using Verification.Core.VerificationCore;

namespace 技术点验证
{
    public class Program
    {
        public static void Main(string[]? args)
        {
            //开始验证
            VerificationHelper.StartVerification(VerificationTypeEnum.A37_构建字符串速度测试, args);
        }
    }
}