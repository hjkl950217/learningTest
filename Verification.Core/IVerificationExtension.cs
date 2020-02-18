using System;
using System.Linq;
using System.Reflection;

namespace Verification.Core
{
    public static class IVerificationExtension
    {
        /// <summary>
        /// 开始验证
        /// </summary>
        /// <param name="typeEnum">要验证的类型</param>
        /// <param name="allVerification">验证库中所有注册的验证接口实例.A系列和B系列是分离的</param>
        /// <param name="args">从命令行中获取的参数</param>
        public static void StartVerification(this IVerification verification, string[] args)
        {
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
    }

    public static class VerificationHelp
    {
        public static void StartVerification(VerificationTypeEnum verificationTypeEnum, string[] args)
        {
            VerificationHelp.GetVerification(verificationTypeEnum)
                .StartVerification(args);
        }

        private static IVerification GetVerification(VerificationTypeEnum verificationTypeEnum)
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

            //判断是否为我们要用的验证类
            Func<Type, bool> isTargetVerification = i =>
            {
                var attr = i.GetCustomAttribute<VerifcationTypeAttribute>();
                if (attr == null)//没有继承的情况-兼容方案
                {
                    //提取验证类中的验证类型
                    PropertyInfo propertyInfo = i.GetProperties()
                        .FirstOrDefault(t => t.PropertyType == typeof(VerificationTypeEnum)
                                && t.CanRead == true
                                && t.CanWrite == false);

                    if (propertyInfo == null) return false;
                    else
                    {
                        try
                        {
                            _ = (IVerification)Activator.CreateInstance(i);//判断是否 有无参数的构造方法
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
                else if (attr.VerificationTypeEnum == verificationTypeEnum)//判断标签中验证类型
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            //组合验证的方法
            Func<Type, bool> typeJudge = i =>
                   isClass(i)
                   && isVerification(i)
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