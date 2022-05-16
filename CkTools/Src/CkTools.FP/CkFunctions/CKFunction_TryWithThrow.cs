using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-抛出异常
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        /// <summary>
        /// Try函数,异常时抛出
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        public static Func<
            Action<TInput>,
            Action<TInput>> TryWithThrow<TInput>(
                [NotNull] Action<TInput, Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<TInput, Exception> exExp1 = (input, ex) => { exExp(input, ex); throw ex; };
            return CkFunctions.Try(exExp1);
        }

        /// <summary>
        /// Try函数,异常时抛出
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        public static Func<
            Action<TInput>,
            Action<TInput>> TryWithThrow<TInput>(
                [NotNull] Action<Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<TInput, Exception> exExp1 = (_, ex) => { exExp(ex); throw ex; };
            return CkFunctions.Try(exExp1);
        }

        /// <summary>
        /// Try函数,异常时抛出
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <param name="exExp"></param>
        /// <returns></returns>
        public static Func<
            Action,
            Action> TryWithThrow(
                [NotNull] Action<Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<Exception> exExp1 = ex => { exExp(ex); throw ex; };
            return CkFunctions.Try(exExp1);
        }

        #endregion Action

        #region Func

        /// <summary>
        /// Try
        /// </summary>
        /// <Value>
        /// <para>函数1：异常处理函数,需要返回发生异常时的返回值</para>
        /// <para>函数2：要执行的函数 </para>
        /// </Value>
        /// <typeparam name="TInput">输入类型参数</typeparam>
        /// <typeparam name="TOutput">输出类型参数</typeparam>
        /// <returns></returns>
        public static Func<
            Func<TInput, TOutput>,
            Func<TInput, TOutput>> TryWithThrow<TInput, TOutput>(
                [NotNull] Action<TInput, Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<TInput, Exception> exExp1 = (input, ex) => { exExp(input, ex); throw ex; };
            return CkFunctions.Try<TInput, TOutput>(exExp1);
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
            Func<TOutput>> TryWithThrow2<TOutput>(
                [NotNull] Action<Exception> exExp)
        {
            CkFunctions.CheckNullWithException(exExp);

            Action<Exception> exExp1 = ex => { exExp(ex); throw ex; };
            return CkFunctions.Try2<TOutput>(exExp1);
        }

        #endregion Func
    }
}