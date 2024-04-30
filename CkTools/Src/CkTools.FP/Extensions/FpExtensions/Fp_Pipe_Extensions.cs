using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 函数式扩展-组合
    /// </summary>
    public static class Fp_Pipe_Extensions
    {
        #region Action

        /*
         竖exp2\横exp1    Action     Action<T>   Action<T1,T2>
         Action             1           1          1
         Action<T>          1           1          2
         Action<T1,T2>      1           2          1
         */

        #region 第1列

        public static Action Pipe(
           this Action exp1,
           [NotNull] Action exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Pipe<TInput>(
            this Action exp1,
            [NotNull] Action<TInput> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
            this Action exp1,
            [NotNull] Action<TInput1, TInput2> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1列

        #region 第2列

        public static Action<TInput> Pipe<TInput>(
            this Action<TInput> exp1,
            [NotNull] Action exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Pipe<TInput>(
            this Action<TInput> exp1,
            [NotNull] Action<TInput> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
            this Action<TInput1> exp1,
            [NotNull] Action<TInput1, TInput2> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
            this Action<TInput2> exp1,
            [NotNull] Action<TInput1, TInput2> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2列

        #region 第3列

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
            this Action<TInput1, TInput2> exp1,
            [NotNull] Action exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
            this Action<TInput1, TInput2> exp1,
            [NotNull] Action<TInput1> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
            this Action<TInput1, TInput2> exp1,
            [NotNull] Action<TInput2> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2>(
             this Action<TInput1, TInput2> exp1,
             [NotNull] Action<TInput1, TInput2> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3列

        #endregion Action

        #region Func

        /*
         竖exp2\横exp1    Func<TR>     Func<T,TR>   Func<T1,T2,TR>
         Func<TR>           x               x              x
         Func<T,TR>         x               1              1
         Func<T1,T2,TR>     x               x              x
         */

        #region 第1列

        #endregion 第1列

        #region 第2列

        public static Func<TInput, TResultEnd> Pipe<TInput, TResultCenter, TResultEnd>(
            this Func<TInput, TResultCenter> exp1,
            [NotNull] Func<TResultCenter, TResultEnd> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2列

        #region 第3列

        public static Func<TInput1, TInput2, TResult> Pipe<TInput1, TInput2, TResultCenter, TResult>(
            this Func<TInput1, TInput2, TResultCenter> exp1,
            [NotNull] Func<TResultCenter, TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3列

        #endregion Func

        #region exp1 Func  -  exp2 Action

        /*
         竖exp2\横exp1    Action     Action<T>   Action<T1,T2>
         Func<TR>           1           x           x
         Func<T,TR>         1           1           x
         Func<T1,T2,TR>     1           x           x

         */

        #region 第1列

        public static Func<TResult> Pipe<TResult>(
            this Action exp1,
            [NotNull] Func<TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            this Action exp1,
            [NotNull] Func<TInput, TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput1, TInput2, TResult> Pipe<TInput1, TInput2, TResult>(
            this Action exp1,
            [NotNull] Func<TInput1, TInput2, TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1列

        #region 第2列

        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            this Action<TInput> exp1,
            [NotNull] Func<TInput, TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2列

        #region 第3列

        #endregion 第3列

        #endregion exp1 Func  -  exp2 Action

        #region exp1 Action  -  exp2 Func

        /*
         竖exp2\横exp1    Func<TR>     Func<T,TR>   Func<T1,T2,TR>
         Action             1           1           1
         Action<T>          x           1           x
         Action<T1,T2>      x           x           1

         */

        #region 第1列

        public static Func<TResult> Pipe<TResult>(
            this Func<TResult> exp1,
            [NotNull] Action exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TResult> Pipe<TResult>(
            this Func<TResult> exp1,
            [NotNull] Action<TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1列

        #region 第2列

        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            this Func<TInput, TResult> exp1,
            [NotNull] Action exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput, TResult> Pipe<TInput, TResult>(
            this Func<TInput, TResult> exp1,
            [NotNull] Action<TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2列

        #region 第3列

        public static Func<TInput1, TInput2, TResult> Pipe<TInput1, TInput2, TResult>(
            this Func<TInput1, TInput2, TResult> exp1,
            [NotNull] Action exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput1, TInput2, TResult> Pipe<TInput1, TInput2, TResult>(
            this Func<TInput1, TInput2, TResult> exp1,
            [NotNull] Action<TResult> exp2)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3列

        #endregion exp1 Action  -  exp2 Func
    }
}