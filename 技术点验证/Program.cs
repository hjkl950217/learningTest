using System;
using System.Collections.Generic;
using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        public static List<IVerification> RegisterAllVerification()
        {
            List<IVerification> verifications = new List<IVerification>();

            #region 验证接口的注册

            verifications.Add(new A01_获取当前路径的方法());
            verifications.Add(new A02_线程ID验证());
            verifications.Add(new A03_时间格式验证());
            verifications.Add(new A04_ConcurrentDictionary的研究());
            verifications.Add(new A05_EFCore学习());
            verifications.Add(new A05_EFCore学习());
            verifications.Add(new A07_动态添加Attribute());
            verifications.Add(new A08_MessagePack基准测试());
            verifications.Add(new A09_读取文件并监控变化());
            verifications.Add(new A10_读取文件到配置系统并监控变化());
            verifications.Add(new A11_日志系统研究());

            #endregion 验证接口的注册

            return verifications;
        }

        private static void Main(string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.A11_日志系统研究;

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