using System.Collections.Generic;
using Verification.Core;

namespace 技术点验证
{
    public class A23_值对象 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A23_值对象;

        public void Start(string[] args)
        {
            List<IdCard> idCards = new List<IdCard>();
            for (int i = 0 ; i < 10_0000 ; i++)
            {
                idCards.Add(new IdCard("01234567891234567X"));
            }
        }
    }
}