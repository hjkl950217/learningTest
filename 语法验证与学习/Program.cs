using System.Collections.Generic;
using Verification.Core;

namespace 语法验证与学习
{
    public class Program
    {
        public static List<IVerification> RegisterAllVerification()
        {
            List<IVerification> verifications = new List<IVerification>();

            #region 注册

            verifications.Add(new B01_建造者模式学习());
            verifications.Add(new B02_类型相关的研究());
            verifications.Add(new B03_协变和逆变());
            verifications.Add(new B04_具有值类型的引用语义_In_72());
            verifications.Add(new B05_表达式树研究());
             verifications.Add(new B06_模式匹配_In_70());

            #endregion 注册

            return verifications;
        }

        private static void Main(string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.B06_模式匹配_In_70;
            List<IVerification> verifications = RegisterAllVerification();

            //开始验证
            VerificationHelp.StartVerification(verificationType, verifications, args);
        }
    }
}