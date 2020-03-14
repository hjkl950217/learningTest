using System;
using System.Linq;
using System.Reflection;

namespace Verification.Core
{
    public static class VerificationHelp
    {
        public static void StartVerification(VerificationTypeEnum verificationTypeEnum, string[] args)
        {
            VerificationHelp.GetVerification(verificationTypeEnum)
                .CheckNull()
                .StartVerification(verificationTypeEnum, args);
        }

        private static VerificationInfo GetVerification(VerificationTypeEnum verificationTypeEnum)
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

                if (attr.VerificationTypeEnum == verificationTypeEnum)//判断标签中验证类型
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

            Type getType()
            {
                Type[] types = AppDomain.CurrentDomain.GetAssemblies()
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
                    .Where(typeJudge)
                    .ToArray();

                switch (types.Length)
                {
                    case int a when a < 1:
                        Console.WriteLine($"{verificationTypeEnum.ToString()}没有找到实现");
                        return null;

                    case int b when b > 1:
                        Console.WriteLine($"找到多个{verificationTypeEnum.ToString()}的实现，请检查");
                        return null;

                    default:
                        return types.First();
                }
            }

            Type type = getType();
            if (type == null)
            {
                throw new NotImplementedException($"{verificationTypeEnum.ToString()} 发生异常");
            }

            #endregion 查找

            return VerificationInfo.Create(verificationTypeEnum, () => (IVerification)Activator.CreateInstance(type));
        }
    }
}