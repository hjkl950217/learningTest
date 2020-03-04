using Verification.Core;

namespace 语法验证与学习.B16_NotNull特性_80
{
    [VerifcationType(VerificationTypeEnum.B16_NotNull特性_80)]
    public class B16_NotNull特性_80 : IVerification
    {
        public void Start(string[] args)
        {
            string a = null;
            System.Console.WriteLine("OK");
        }
    }
}