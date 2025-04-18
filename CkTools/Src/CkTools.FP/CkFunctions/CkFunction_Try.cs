﻿using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-异常处理
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        /// <summary>
        /// 异常处理（无异常抛出，有需要请在<paramref name="exExp"/>中处理）
        /// </summary>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput1"></typeparam>
        /// <param name="exExp">异常处理函数，会将调用参数传递进去</param>
        /// <param name="exp">处理函数</param>
        /// <returns></returns>
        public static Action<TInput2?, TInput1?> Try<TInput2, TInput1>(
            Action<TInput2?, TInput1?, Exception> exExp,
            Action<TInput2?, TInput1?> exp)
        {
            return (input2, input1) =>
            {
                try
                {
                    exp(input2, input1);
                }
                catch(Exception ex)
                {
                    exExp(input2, input1, ex);
                }
            };
        }

        /// <summary>
        /// 异常处理（无异常抛出，有需要请在<paramref name="exExp"/>中处理）
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="exExp">异常处理函数，会将调用参数传递进去</param>
        /// <param name="exp">处理函数</param>
        /// <returns></returns>
        public static Action<TInput?> Try<TInput>(
            Action<TInput?, Exception> exExp,
            Action<TInput?> exp)
        {
            return input =>
            {
                try
                {
                    exp(input);
                }
                catch(Exception ex)
                {
                    exExp(input, ex);
                }
            };
        }

        /// <summary>
        /// 异常处理（无异常抛出，有需要请在<paramref name="exExp"/>中处理）
        /// </summary>
        /// <param name="exExp">异常处理函数，会将调用参数传递进去</param>
        /// <param name="exp">处理函数</param>
        /// <returns></returns>
        public static Action Try(
            Action<Exception> exExp,
            Action exp)
        {
            return () =>
            {
                try
                {
                    exp();
                }
                catch(Exception ex)
                {
                    exExp(ex);
                }
            };
        }

        #endregion Action

        #region Func

        /// <summary>
        /// 异常处理（无异常抛出，有需要请在<paramref name="exExp"/>中处理）
        /// </summary>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TReuslt"></typeparam>
        /// <param name="exExp">异常处理函数，会将调用参数传递进去</param>
        /// <param name="exp">处理函数</param>
        /// <returns></returns>
        public static Func<TInput2?, TInput1?, TReuslt?> Try<TInput2, TInput1, TReuslt>(
            Action<TInput2?, TInput1?, Exception> exExp,
            Func<TInput2?, TInput1?, TReuslt?> exp)
        {
            return (input2, input1) =>
            {
                try
                {
                    return exp(input2, input1);
                }
                catch(Exception ex)
                {
                    exExp(input2, input1, ex);
                    return default;
                }
            };
        }

        /// <summary>
        /// 异常处理（无异常抛出，有需要请在<paramref name="exExp"/>中处理）
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TReuslt"></typeparam>
        /// <param name="exExp">异常处理函数，会将调用参数传递进去</param>
        /// <param name="exp">处理函数</param>
        /// <returns></returns>
        public static Func<TInput, TReuslt?> Try<TInput, TReuslt>(
            Action<TInput, Exception> exExp,
            Func<TInput, TReuslt?> exp)
        {
            return input =>
            {
                try
                {
                    return exp(input);
                }
                catch(Exception ex)
                {
                    exExp(input, ex);
                    return default;
                }
            };
        }

        /// <summary>
        /// 异常处理（无异常抛出，有需要请在<paramref name="exExp"/>中处理）
        /// </summary>
        /// <typeparam name="TReuslt"></typeparam>
        /// <param name="exExp">异常处理函数，会将调用参数传递进去</param>
        /// <param name="exp">处理函数</param>
        /// <returns></returns>
        public static Func<TReuslt?> Try<TReuslt>(
            Action<Exception> exExp,
            Func<TReuslt?> exp)
        {
            return () =>
            {
                try
                {
                    return exp();
                }
                catch(Exception ex)
                {
                    exExp(ex);
                    return default;
                }
            };
        }

        #endregion Func
    }
}