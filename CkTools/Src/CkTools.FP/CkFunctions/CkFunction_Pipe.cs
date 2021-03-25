using System;
using System.Collections.Generic;
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
        /// 管道
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Func<TOutput> Pipe<TOutput>(
            [NotNull] Func<TOutput> exp,
            [NotNull] params Action<TOutput>[] exps)
        {
            exp.CheckNullWithException(nameof(exp));
            exps.CheckNullWithException(nameof(exps));

            return () =>
            {
                TOutput result = exp();
                exps.For(t => t(result));
                return result;
            };
        }

        #endregion Func - 0入参 1出参

        #region Fun - 1入参 1出参

        #endregion Fun - 1入参 1出参

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <param name="exp"></param>
        ///// <param name="exps"></param>
        ///// <returns></returns>
        //public static Func<TOutput> Pipe<TOutput>(
        //    [NotNull] Func<TOutput> exp,
        //    [NotNull] params Action<TOutput>[] exps)
        //{
        //    exp.CheckNullWithException(nameof(exp));
        //    exps.CheckNullWithException(nameof(exps));

        //    return () =>
        //    {
        //        TOutput result = exp();
        //        exps.For(t => t(result));
        //        return result;
        //    };
        //}

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp,
            [NotNull] params Func<TResult, TResult>[] exps)
        {
            exp.CheckNullWithException(nameof(exp));
            exps.CheckNullWithException(nameof(exps));

            return t =>
            {
                TResult tempResult = exp(t);
                exps.For(item => tempResult = item(tempResult));
                return tempResult;
            };
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp,
            [NotNull] params Action<TResult>[] exps)
        {
            exp.CheckNullWithException(nameof(exp));
            exps.CheckNullWithException(nameof(exps));

            return input =>
            {
                TResult tempResult = exp(input);
                exps.For(item => item(tempResult));

                return tempResult;
            };
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TCenter"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TCenter, TResult>(
          [NotNull] Func<TInput, TCenter> exp,
          [NotNull] Func<TCenter, TResult> func)
        {
            exp.CheckNullWithException(nameof(exp));
            func.CheckNullWithException(nameof(func));
            return t => func(exp(t));
        }
    }
}