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

        /* 竖 exp2  横 exp1
                        Action     Action<T>   Action<T2,T1>
         Action         1           1          1
         Action<T>      1           1          2
         Action<T2,T1>  1           2          1
         */

        #region 第1排

        public static Action Pipe(
            [NotNull] Action exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Action<TInput> Pipe<TInput>(
         [NotNull] Action<TInput> exp2,
         [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
         [NotNull] Action<TInput2, TInput1> exp2,
         [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3排

        #region 其它

        public static Action Pipe(
            [NotNull] Action exp5,
            [NotNull] Action exp4,
            [NotNull] Action exp3,
            [NotNull] Action? exp2 = null,
            [NotNull] Action? exp1 = null)
        {
            CheckNullWithException(exp5, exp4, exp3);

            Action result = Pipe(exp5, exp4);
            result = Pipe(result, exp3);
            if (exp2 != null) result = Pipe(result, exp2);
            if (exp1 != null) result = Pipe(result, exp1);
#pragma warning disable CS8777 // 退出时，参数必须具有非 null 值。
            return result;
#pragma warning restore CS8777 // 退出时，参数必须具有非 null 值。
        }

        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action<TInput> exp5,
            [NotNull] Action<TInput> exp4,
            [NotNull] Action<TInput> exp3,
            [NotNull] Action<TInput>? exp2 = null,
            [NotNull] Action<TInput>? exp1 = null)
        {
            CheckNullWithException(exp5, exp4, exp3);

            Action<TInput> result = Pipe(exp5, exp4);
            result = Pipe(result, exp3);
            if (exp2 != null) result = Pipe(result, exp2);
            if (exp1 != null) result = Pipe(result, exp1);
#pragma warning disable CS8777 // 退出时，参数必须具有非 null 值。
            return result;
#pragma warning restore CS8777 // 退出时，参数必须具有非 null 值。
        }

        #endregion 其它

        #endregion Action

        #region Func

        /* 竖 exp2  横 exp1
                        Func<TR>     Func<T,TR>   Func<T2,T1,TR>
         Func<TR>       x               x              x
         Func<T,TR>     1               1              1
         Func<T2,T1,TR> x               x              x
         */

        #region 第2排

        public static Func<TResult> Pipe<TResult>(
            [NotNull] Func<TResult, TResult> exp2,
            [NotNull] Func<TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            [NotNull] Func<TResult, TResult> exp2,
            [NotNull] Func<TInput, TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput2, TInput1, TResult> Pipe<TInput2, TInput1, TResult>(
            [NotNull] Func<TResult, TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2排

        #endregion Func

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
        //    CkFunctions.CheckNullWithException(exp, exps);

        //    return () =>
        //    {
        //        TOutput result = exp();
        //        exps.For(t => t(result));
        //        return result;
        //    };
        //}

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

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <typeparam name="TInput"></typeparam>
        ///// <typeparam name="TResult"></typeparam>
        ///// <param name="exp"></param>
        ///// <param name="exps"></param>
        ///// <returns></returns>
        //public static Func<TInput, TResult> Pipe<TInput, TResult>(
        //    [NotNull] Func<TInput, TResult> exp,
        //    [NotNull] params Func<TResult, TResult>[] exps)
        //{
        //    CkFunctions.CheckNullWithException(exp, exps);

        //    return t =>
        //    {
        //        TResult tempResult = exp(t);
        //        exps.For(item => tempResult = item(tempResult));
        //        return tempResult;
        //    };
        //}

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <typeparam name="TInput"></typeparam>
        ///// <typeparam name="TResult"></typeparam>
        ///// <param name="exp"></param>
        ///// <param name="exps"></param>
        ///// <returns></returns>
        //public static Func<TInput, TResult> Pipe<TInput, TResult>(
        //    [NotNull] Func<TInput, TResult> exp,
        //    [NotNull] params Action<TResult>[] exps)
        //{
        //    CkFunctions.CheckNullWithException(exp, exps);

        //    return input =>
        //    {
        //        TResult tempResult = exp(input);
        //        exps.For(item => item(tempResult));

        //        return tempResult;
        //    };
        //}

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