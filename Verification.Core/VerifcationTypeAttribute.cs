using System;

namespace Verification.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class VerifcationTypeAttribute : Attribute
    {
        public VerifcationTypeAttribute(VerificationTypeEnum verificationTypeEnum)
        {
            this.VerificationTypeEnum = verificationTypeEnum;
        }

        public VerificationTypeEnum VerificationTypeEnum { get; }
    }
}