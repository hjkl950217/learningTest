using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Func - 0入参 1出参

        /// <summary>
        /// 管道,返回一个包含异常处理的函数
        /// </summary>
        /// <Value>
        /// <para><paramref name="sourceFunc"/>：要附加try操作的函数 </para>
        /// <para><paramref name="handler"/>：异常处理函数 </para>
        /// </Value>
        /// <typeparam name="TOutput"></typeparam>
        /// <returns></returns>
        public static Func<TOutput> PipeTry<TOutput>(
            [NotNull] Func<TOutput> sourceFunc,
            [NotNull] Func<Exception, TOutput> handler)
        {
            sourceFunc.CheckNullWithException(nameof(sourceFunc));
            handler.CheckNullWithException(nameof(handler));

            return CkFunctions.Try(sourceFunc, handler);
        }

        #endregion Func - 0入参 1出参

        #region Func - 1入参 1出参

        /// <summary>
        /// 管道,返回一个包含异常处理的函数
        /// </summary>
        /// <Value>
        /// <para><paramref name="sourceFunc"/>：要附加try操作的函数 </para>
        /// <para><paramref name="handler"/>：异常处理函数 </para>
        /// </Value>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <returns></returns>
        public static Func<TInput, TOutput> PipeTry<TInput, TOutput>(
            [NotNull] Func<TInput, TOutput> sourceFunc,
            [NotNull] Func<TInput, Exception, TOutput> handler)
        {
            sourceFunc.CheckNullWithException(nameof(sourceFunc));
            handler.CheckNullWithException(nameof(handler));

            return CkFunctions.Try(sourceFunc, handler);
        }

        #endregion Func - 1入参 1出参
    }
}