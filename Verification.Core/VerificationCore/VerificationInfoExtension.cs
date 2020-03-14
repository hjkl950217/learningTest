using System;
using System.Diagnostics.CodeAnalysis;

namespace Verification.Core
{
    public static class VerificationInfoExtension
    {
        public static VerificationInfo CheckNull(this VerificationInfo verification)
        {
            if (verification == null)
            {
                throw new NotImplementedException($"{verification.VerificationType.ToString()} 发生异常");
            }

            return verification;
        }

        /// <summary>
        /// 开始验证
        /// </summary>
        /// <param name="typeEnum">要验证的类型</param>
        /// <param name="allVerification">验证库中所有注册的验证接口实例.A系列和B系列是分离的</param>
        /// <param name="args">从命令行中获取的参数</param>
        public static VerificationInfo StartVerification(
            this VerificationInfo verification,
            VerificationTypeEnum verificationTypeEnum,
            string[] args)
        {
            Console.WriteLine("开始验证");
            Console.WriteLine($"验证:\t-{verificationTypeEnum.ToString()}-");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            verification.VerificationInstance.Start(args);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine("验证结束");
            Console.ReadLine();

            return verification;
        }
    }

    public static class FP
    {
        /// <summary>
        /// 创建管道
        /// </summary>
        /// <typeparam name="TInput">输入参数类型</typeparam>
        /// <typeparam name="TResult">输出结果类型</typeparam>
        /// <param name="predicate">如果判断输出结果是否正确.不判断时请传递null</param>
        /// <param name="errorAction">判断失败时，如何处理？如果传递null或<paramref name="predicate"/>也为null，则不会执行</param>
        /// <param name="aggregate">累计函数，指示如何累加</param>
        /// <returns></returns>
        public static Func<TInput, TResult> CreatePipe<TInput, TResult>(
            Func<TResult, bool> predicate,
            Action<TInput, TResult> errorAction,
            Func<TResult, TResult> aggregate,
            params Func<TInput, TResult>[] funcs)
        {
            errorAction = errorAction == null || predicate == null ? (i, r) => { } : errorAction;
            predicate ??= t => true;
            funcs ??= Array.Empty<Func<TInput, TResult>>();

            return input =>
            {
                TResult result = default;
                foreach (var item in funcs)
                {
                    result = item(input);

                    if (!predicate(result)) errorAction(input, result);
                }
                return result;
            };
        }

        /// <summary>
        /// 用于快速创建累加器的方法。使用时传递需要的部分即可
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="seed"></param>
        /// <param name="func"></param>
        /// <param name="resultSelter"></param>
        /// <returns></returns>
        private static Func<TResult, TResult> FastCreateAggregater<TResult>(
            [NotNull] Func<TResult, TResult, TResult> func,
            TResult seed = default,
            Func<TResult, TResult>? resultSelter = null
            )
        {
            //  System.Linq.Enumerable.Aggregate

            resultSelter ??= t => t;
            TResult result = seed;
            return (next) => resultSelter(func(result, next));
        }
    }
}