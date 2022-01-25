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

        /*
         竖exp1\横exp2    Action     Action<T>   Action<T2,T1>
         Action            x*           1          1
         Action<T>          1           1          2
         Action<T2,T1>      1           2          1
         */

        #region 第1排

        public static Action<TInput> Pipe<TInput>(
         [NotNull] Action<TInput> exp2,
         [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
         [NotNull] Action<TInput2, TInput1> exp2,
         [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Action<TInput> Pipe<TInput>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput> exp1)
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

        #endregion 第2排

        #region 第3排

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
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

        public static Action<TInput2, TInput1> Pipe<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3排

        #region 其它

        public static Action Pipe(
             params Action[] exps)
        {
            CheckNullWithException(exps);

            return Compose(exps);
        }

        public static Action<TInput> Pipe<TInput>(
             params Action<TInput>[] exps)
        {
            CheckNullWithException(exps);

            return Compose(exps);
        }

        #endregion 其它

        #endregion Action

        #region Func

        /*
         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
         Func<TR>           x               x              x
         Func<T,TR>         1               2              1
         Func<T2,T1,TR>     x               x              x
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

        public static Func<TInput, TResultEnd> Pipe<TInput, TResult1, TResultEnd>(
            [NotNull] Func<TResult1, TResultEnd> exp2,
            [NotNull] Func<TInput, TResult1> exp1)
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

        #region 其它

        public static Func<TResult> Pipe<TResult>(
            [NotNull] Action<TResult>[] exps2,
            [NotNull] Func<TResult> exp1)
        {
            CkFunctions.CheckNullWithException(exp1);
            CkFunctions.CheckNullWithException(exps2);

            return CkFunctions.Compose(exps2, exp1);
        }

        #endregion 其它

        #endregion Func
    }
}