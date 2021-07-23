using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action - 0入参 0出参

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exExp"/>：异常处理函数</para>
        /// </Value>
        /// <returns></returns>
        public static Action Try(
            [NotNull] Action exp,
            [NotNull] Action<Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return () => { try { exp(); } catch (Exception ex) { exExp(ex); } };
        }

        #endregion Action - 0入参 0出参

        #region Action - 1入参 0出参

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
            [NotNull] Action<TInput> exp,
            [NotNull] Action<TInput, Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return input => { try { exp(input); } catch (Exception ex) { exExp(input, ex); } };
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
            Action<TInput> exp,
            Action<Exception> exEXP)
        {
            return CkFunctions.Try(exp, (input, ex) => exEXP(ex));
        }

        #endregion Action - 1入参 0出参

        #region Func - 0入参 1出参

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
            [NotNull] Func<TOutput> exp,
            [NotNull] Func<Exception, TOutput> exExp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return () => { try { return exp(); } catch (Exception ex) { return exExp(ex); } };
        }

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exExp"/>：异常处理函数,需要返回发生异常时的返回值</para>
        /// </Value>
        /// <typeparam name="TOutput">输出类型参数</typeparam>
        /// <returns></returns>
        public static Func<TOutput> TryWithThrow<TOutput>(
            [NotNull] Func<TOutput> exp,
            [NotNull] Action<Exception> exEXP)
        {
            return CkFunctions.Try(exp, ex => { exEXP(ex); throw ex; });
        }

        #endregion Func - 0入参 1出参

        #region Func - 1入参 1出参

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
            [NotNull] Func<TInput, TOutput> exp,
            [NotNull] Func<TInput, Exception, TOutput> exExp)
        {
            CkFunctions.CheckNullWithException(exp, exExp);

            return input => { try { return exp(input); } catch (Exception ex) { return exExp(input, ex); } };
        }

        #endregion Func - 1入参 1出参
    }
}