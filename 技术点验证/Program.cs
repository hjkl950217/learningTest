using System;
using System.Collections.Generic;
using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        private static void Main(string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.A2_线程ID验证;

            List<IVerification> verifications = RegisterAllVerification();
            IVerification verification = GetVerification(verifications, verificationType);

            Console.WriteLine("开始验证");
            Console.WriteLine($"验证:{verification.VerificationType.ToString()}");
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

        public static List<IVerification> RegisterAllVerification()
        {
            List<IVerification> verifications = new List<IVerification>();

            #region 验证接口的注册

            verifications.Add(new A_获取当前路径的方法());
            verifications.Add(new B_线程ID验证());
            verifications.Add(new C_时间格式验证());

            #endregion 验证接口的注册

            return verifications;
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