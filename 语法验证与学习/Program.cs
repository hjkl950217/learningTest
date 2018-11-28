using System;
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

            verifications.Add(new B1_建造者模式学习());
            verifications.Add(new B2_类型相关的研究());
            verifications.Add(new B3_协变和逆变());
            verifications.Add(new B4_具有值类型的引用语义_In_72());
            verifications.Add(new B5_表达式树研究());
            verifications.Add(new B6_扫描泛型接口());

            #endregion 注册

            return verifications;
        }

        private static void Main(string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.B5_表达式树研究;

            List<IVerification> verifications = RegisterAllVerification();
            IVerification verification = GetVerification(verifications, verificationType);

            Console.WriteLine("开始验证");
            Console.WriteLine($"验证:\t-{verification.VerificationType.ToString()}-");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            verification.Start(args);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine("验证结束");
            Console.ReadLine();
        }

        /// <summary>
        /// 获取验证接口的实例
        /// </summary>
        /// <param name="verifications"></param>
        /// <param name="verificationType"></param>
        /// <returns></returns>
        public static IVerification GetVerification(List<IVerification> verifications, VerificationTypeEnum verificationType)
        {
            return verifications.Find(t => t.VerificationType == verificationType);
        }
    }
}