using System.Collections.Generic;
using Verification.Core;

namespace 语法验证与学习
{
    public class Program
    {
        private static void Main(string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.B12_Switch_In_80;
            List<IVerification> verifications = RegisterAllVerification();

            //开始验证
            VerificationHelp.StartVerification(verificationType, verifications, args);
        }

        public static List<IVerification> RegisterAllVerification()
        {
            List<IVerification> verifications = new List<IVerification>();

            #region 注册

            verifications.Add(new B01_建造者模式学习());
            verifications.Add(new B02_用反射设置值());
            verifications.Add(new B03_协变和逆变());
            verifications.Add(new B04_具有值类型的引用语义_In_72());
            verifications.Add(new B05_表达式树研究());
            verifications.Add(new B06_模式匹配_In_70());
            verifications.Add(new B07_递归());
            verifications.Add(new B08_Chsarp中写函数式编程());
            verifications.Add(new B09_访问者模式());
            verifications.Add(new B10_I__的原子性());
            verifications.Add(new B11_表达式树修改());
            verifications.Add(new B12_Switch_In_80());

            #endregion 注册

            return verifications;
        }
    }
}