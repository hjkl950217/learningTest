using System;
using Verification.Core;

namespace 技术点验证
{
    public class A23_值对象 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A23_值对象;

        public void Start(string[] args)
        {
            this.Show(() => _ = new IdCard("012345678912345678"));
            this.Show(() => _ = new IdCard("01234567891234567X"));
            this.TryShow(() => _ = new IdCard("01234567891234567x"));
            this.TryShow(() => _ = new IdCard("01234567891234567-"));

            this.Show(() => _ = new Age(25));
            this.TryShow(() => _ = new Age(18));
            this.TryShow(() => _ = new Age(-1));

            this.Show(() => _ = MemberType.Create(500));
            this.TryShow(() => _ = MemberType.Create(-500));

            this.TryShow(() => _ = MemberType.Create(new IdCardNo(255)));
        }

        public void Show(Action action) => action();

        public void TryShow(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}