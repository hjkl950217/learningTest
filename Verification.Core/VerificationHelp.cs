using System;
using System.Collections.Generic;

namespace Verification.Core
{
    /// <summary>
    /// 验证帮助类
    /// </summary>
    public static class VerificationHelp
    {
        public static void StartVerification(
            VerificationTypeEnum typeEnum, 
            List<IVerification> allVerification,
            string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.B06_模式匹配_In_70;

            IVerification verification = VerificationHelp.GetVerification(allVerification, verificationType);

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
        private static IVerification GetVerification(List<IVerification> verifications, VerificationTypeEnum verificationType)
        {
            IVerification result = verifications.Find(t => t.VerificationType == verificationType);

            if (result == null)
            {
                Console.WriteLine($"{verificationType} 没有注册");
            }

            return result;
        }


    }
}