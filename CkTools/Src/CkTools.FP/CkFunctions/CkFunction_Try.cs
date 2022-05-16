using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-异常处理
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数</para>
        /// <para>函数2：执行函数 </para>
        /// </Value>
        /// <typeparam name="TInput">输入参数类型</typeparam>
        /// <returns></returns>
        public static Func<
            Action<TInput>,
            Action<TInput>> Try<TInput>(
                [NotNull] Action<TInput, Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            return
                exp =>
                input =>
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
        /// <para>函数1：异常处理函数</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <typeparam name="TInput">输入参数类型</typeparam>
        /// <returns></returns>
        public static Func<
            Action<TInput>,
            Action<TInput>> Try<TInput>(
                [NotNull] Action<Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<TInput, Exception> exp1 = (_, ex) => exExp(ex);
            return CkFunctions.Try<TInput>(exp1);
        }

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<
            Action,
            Action> Try(
                [NotNull] Action<Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<int, Exception> exp1 = (_, ex) => exExp(ex);
            return
                exp =>
                () => CkFunctions.Try<int>(exp1)(t => exp())(0);
        }

        #endregion Action

        #region Func

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数,需要返回一个值</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <typeparam name="TInput">输入类型参数</typeparam>
        /// <typeparam name="TOutput">输出类型参数</typeparam>
        /// <returns></returns>
        public static Func<
            Func<TInput, TOutput>,
            Func<TInput, TOutput>> Try<TInput, TOutput>(
                [NotNull] Action<TInput, Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            return
                exp =>
                input =>
                {
                    try
                    {
                        return exp(input);
                    }
                    catch (Exception ex)
                    {
                        exExp(input, ex);
                    }
                    return default(TOutput);//这行是为了编译器能识别
                };
        }

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数,需要返回发生异常时的返回值</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <typeparam name="TOutput">输出类型参数</typeparam>
        /// <returns></returns>
        public static Func<
            Func<TOutput>,
            Func<TOutput>> Try2<TOutput>(
                [NotNull] Action<Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<int, Exception> exExp1 = (_, ex) => exExp(ex);
            return
                exp =>
                () => CkFunctions.Try<int, TOutput>(exExp1)(t => exp())(0);
        }

        #endregion Func
    }
}