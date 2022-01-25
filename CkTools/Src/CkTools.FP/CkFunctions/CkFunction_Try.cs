using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exExp"/>：异常处理函数</para>
        /// </Value>
        /// <returns></returns>
        public static Action Try(
            [NotNull] Action<Exception> exExp,
            [NotNull] Action exp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return () =>
            {
                try
                {
                    exp();
                }
                catch (Exception ex)
                {
                    exExp(ex);
                }
            };
        }

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exExp"/>：异常处理函数</para>
        /// </Value>
        /// <typeparam name="TInput">输入参数类型</typeparam>
        /// <returns></returns>
        public static Action<TInput> Try<TInput>(
            [NotNull] Action<TInput, Exception> exExp,
            [NotNull] Action<TInput> exp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return input =>
            {
                try
                {
                    exp(input);
                }
                catch (Exception ex)
                {
                    exExp(input, ex);
                }
            };
        }

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exExp"/>：异常处理函数</para>
        /// </Value>
        /// <typeparam name="TInput">输入参数类型</typeparam>
        /// <returns></returns>
        public static Action<TInput> Try<TInput>(
            Action<Exception> exExp,
            Action<TInput> exp)
        {
            return CkFunctions.Try((_, ex) => exExp(ex), exp);
        }

        #endregion Action

        #region Func

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exExp"/>：异常处理函数,需要返回发生异常时的返回值</para>
        /// </Value>
        /// <typeparam name="TOutput">输出类型参数</typeparam>
        /// <returns></returns>
        public static Func<TOutput> Try<TOutput>(
            [NotNull] Func<Exception, TOutput> exExp,
            [NotNull] Func<TOutput> exp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return () =>
            {
                try
                {
                    return exp();
                }
                catch (Exception ex)
                {
                    return exExp(ex);
                }
            };
        }

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exExp"/>：异常处理函数,需要返回一个值</para>
        /// </Value>
        /// <typeparam name="TInput">输入类型参数</typeparam>
        /// <typeparam name="TOutput">输出类型参数</typeparam>
        /// <returns></returns>
        public static Func<TInput, TOutput> Try<TInput, TOutput>(
            [NotNull] Func<TInput, Exception, TOutput> exExp,
            [NotNull] Func<TInput, TOutput> exp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return input =>
            {
                try
                {
                    return exp(input);
                }
                catch (Exception ex)
                {
                    return exExp(input, ex);
                }
            };
        }

        #endregion Func
    }
}