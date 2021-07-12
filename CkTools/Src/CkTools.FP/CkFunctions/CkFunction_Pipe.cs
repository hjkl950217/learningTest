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
        #region 返回Action

        #region 0个入参

        /// <summary>
        /// 管道 <para></para>
        /// (a->void)->(b->void)->...  => (a->void) <para></para>
        /// 示例:  (string->void)->(int->void)->...  => (string->void)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="sourceExp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action<TInput> sourceExp,
            [NotNull] params Action<TInput>[] exps)
        {
            sourceExp.CheckNullWithException(nameof(sourceExp));
            exps.CheckNullWithException(nameof(exps));

            return t =>
            {
                sourceExp(t);
                foreach (Action<TInput> item in exps)
                {
                    item(t);
                }
            };
        }

        #endregion 0个入参

        #endregion 返回Action

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

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <typeparam name="TInput"></typeparam>
        ///// <typeparam name="TCenter"></typeparam>
        ///// <typeparam name="TResult"></typeparam>
        ///// <param name="exp"></param>
        ///// <param name="func"></param>
        ///// <returns></returns>
        //public static Func<TInput, TResult> Pipe<TInput, TCenter, TResult>(
        //  [NotNull] Func<TInput, TCenter> exp,
        //  [NotNull] Func<TCenter, TResult> func)
        //{
        //    exp.CheckNullWithException(nameof(exp));
        //    func.CheckNullWithException(nameof(func));
        //    return t => func(exp(t));
        //}
    }
}