using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Verification.Core;

namespace 技术点验证
{
    public class Program
    {
        private static void Main(string[] args)
        {
            VerificationTypeEnum verificationType = VerificationTypeEnum.A01_获取当前路径的方法;
            List<IVerification> verifications = RegisterAllVerification();

            //IVerification verification = GetVerification(VerificationTypeEnum.A01_获取当前路径的方法);

            //开始验证
            VerificationHelp.StartVerification(verificationType, verifications, args);
        }

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
            verifications.Add(new A12_扫描泛型接口_判断类型());
            verifications.Add(new A13_Asynclocal的坑());
            verifications.Add(new A14_查找相同对象的基准测试());
            verifications.Add(new A15_分割字符串的基准测试());
            verifications.Add(new A16_懒加载());
            verifications.Add(new A17_马尔科夫链());
            verifications.Add(new A18_预测鸢尾花的类型_多类分类());
            verifications.Add(new A19_熵的计算());
            verifications.Add(new A20_并行查找数组中非0的索引());
            verifications.Add(new A21_实体方法空间占用());
            verifications.Add(new A22_从表达式中解析成员变量名());
            verifications.Add(new A23_值对象());

            #endregion 验证接口的注册

            return verifications;
        }

        public static IVerification GetVerification(VerificationTypeEnum verificationTypeEnum)
        {
            //todo: 优化查找-->运行的方式

            #region 查找

            //判断是否为class
            Func<Type, bool> isClass = i =>
            {
                return i.IsClass //类
                       && i.IsPublic //公共的
                       ;
            };

            //判断是否为验证类
            Func<Type, bool> isVerification = i =>
            {
                return i.GetInterfaces().Contains(typeof(IVerification));
            };

            //判断是否为只有一个构造方法，且是无参数的
            Func<Type, bool> isOnlyOne_NonParameterConstructor = i =>
            {
                return i.GetConstructor(
                    bindingAttr: BindingFlags.Public,
                    binder: null,
                    types: null,
                    modifiers: null) != null;
            };

            //判断是否为我们要用的验证类
            Func<Type, bool> isTargetVerification = i =>
            {
                //提取验证类中的验证类型
                PropertyInfo propertyInfo = i.GetProperties()
                    .FirstOrDefault(t => t.PropertyType == typeof(VerificationTypeEnum)
                            && t.CanRead == true
                            && t.CanWrite == false);

                //判断是否为我们需要的
                if (propertyInfo == null) return false;
                else
                {
                    //这里要修改成  判断Attribute

                    return (VerificationTypeEnum)propertyInfo.GetMethod.Invoke(null, null) == verificationTypeEnum;
                }
            };

            //组合验证的方法
            Func<Type, bool> typeJudge = i =>
                   isClass(i)
                   && isVerification(i)
                   //&& isOnlyOne_NonParameterConstructor(i)
                   && isTargetVerification(i);

            Type type = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(i =>
                {
                    try
                    {
                        return i.GetExportedTypes();
                    }
                    catch
                    {
                        return new Type[0];
                    }
                })
                .FirstOrDefault(typeJudge);

            if (type == null)
            {
                throw new NotImplementedException($"{verificationTypeEnum.ToString()} 没有找到实现");
            }

            #endregion 查找

            return (IVerification)Activator.CreateInstance(type);
        }
    }
}