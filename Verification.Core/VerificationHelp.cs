using System;
using System.Collections.Generic;

namespace Verification.Core
{
    /// <summary>
    /// 验证帮助类
    /// </summary>
    public static class VerificationHelp
    {
        /// <summary>
        /// 开始验证
        /// </summary>
        /// <param name="typeEnum">要验证的类型</param>
        /// <param name="allVerification">验证库中所有注册的验证接口实例.A系列和B系列是分离的</param>
        /// <param name="args">从命令行中获取的参数</param>
        public static void StartVerification(
            VerificationTypeEnum typeEnum,
            List<IVerification> allVerification,
            string[] args)
        {
            IVerification verification = VerificationHelp.GetVerification(allVerification, typeEnum);

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
                throw new ArgumentNullException($"{verificationType} 没有注册");
            }

            return result;
        }

        #region 快速和添加子验证方法

        public class TempLiknObject { }//用来关联方法的内部对象

        private static readonly List<Action> actions = new List<Action>();//用来临时装子验证方法
        private static readonly TempLiknObject tempLiknObject = new TempLiknObject();//启动时直接new,避免以后再new

        /// <summary>
        /// 添加一个要执行的子验证方法
        /// </summary>
        /// <param name="verification"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static TempLiknObject Add(Action action)
        {
            VerificationHelp.actions.Add(action);
            return VerificationHelp.tempLiknObject;
        }

        /// <summary>
        /// 添加一个要执行的子验证方法
        /// </summary>
        /// <param name="verification"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static TempLiknObject AddRange(params Action[] action)
        {
            action = action ?? new Action[0];
            VerificationHelp.actions.AddRange(action);
            return VerificationHelp.tempLiknObject;
        }

        /// <summary>
        /// 批量执行子验证方法
        /// </summary>
        /// <param name="t"></param>
        /// <param name="outputAciton"></param>
        public static void BatchRun(this TempLiknObject t, Action<string> outputAciton = null)
        {
            outputAciton = outputAciton ?? Console.WriteLine;
            foreach (var item in VerificationHelp.actions)
            {
                item();//执行示例的委托
                outputAciton("--------------------------------");
                outputAciton(string.Empty);
            }
        }

        #endregion 快速和添加子验证方法
    }
}