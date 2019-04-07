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
            verifications.Add(new A12_扫描泛型接口());
            verifications.Add(new A13_Asynclocal的坑());
            verifications.Add(new A14_查找相同对象的基准测试());
            verifications.Add(new A15_分割字符串的基准测试());
            verifications.Add(new A16_懒加载());
            verifications.Add(new A17_马尔科夫链());

            #endregion 验证接口的注册

            return verifications;
        }

        private static void Main(string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.A17_马尔可夫链链;
            List<IVerification> verifications = RegisterAllVerification();

            //开始验证
            VerificationHelp.StartVerification(verificationType, verifications, args);
        }

    }
}