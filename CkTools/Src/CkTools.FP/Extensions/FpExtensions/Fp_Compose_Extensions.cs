using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 函数式扩展-组合
    /// </summary>
    public static class Fp_Compose_Extensions
    {
        #region Action

        /*
         竖exp1\横exp2    Action     Action<T>   Action<T2,T1>
         Action             1           1          1
         Action<T>          1           1          2
         Action<T2,T1>      1           x          1
         */

        #region 第1排

        public static Action Compose(
           this Action exp2,
           [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Compose<TInput>(
           this Action<TInput> exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
            this Action<TInput2, TInput1> exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Action<TInput> Compose<TInput>(
            this Action exp2,
            [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Compose<TInput>(
            this Action<TInput> exp2,
            [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
           this Action<TInput2, TInput1> exp2,
           [NotNull] Action<TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput, TInput> Compose<TInput>(
          this Action<TInput, TInput> exp2,
          [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose<TInput>(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
            this Action exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
             this Action<TInput2, TInput1> exp2,
             [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3排

        #endregion Action

        #region Func

        /*
         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
         Func<TR>           x               1              x
         Func<T,TR>         x               1              x
         Func<T2,T1,TR>     x               1              x
         */

        #region 第1排

        public static Func<TResultEnd> Compose<TResult1, TResultEnd>(
            this Func<TResult1, TResultEnd> exp2,
            [NotNull] Func<TResult1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Func<TInput, TResultEnd> Compose<TInput, TResult1, TResultEnd>(
            this Func<TResult1, TResultEnd> exp2,
            [NotNull] Func<TInput, TResult1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            this Func<TResult, TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3排

        #endregion Func

        #region exp1 Func  -  exp2 Action

        /* 竖
         竖exp1\横exp2    Action     Action<T>   Action<T2,T1>
         Func<TR>           1           1           x
         Func<T,TR>         1           1           x
         Func<T2,T1,TR>     1           1           x

         */

        #region 第1排

        public static Func<TResult> Compose<TResult>(
            this Action exp2,
            [NotNull] Func<TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TResult> Compose<TResult>(
            this Action<TResult> exp2,
            [NotNull] Func<TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            this Action exp2,
            [NotNull] Func<TInput, TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            this Action<TResult> exp2,
            [NotNull] Func<TInput, TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            this Action exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            this Action<TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3排

        #endregion exp1 Func  -  exp2 Action

        #region exp1 Action  -  exp2 Func

        /*
         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
         Action             1           1           1
         Action<T>          x           1           x
         Action<T2,T1>      x           x           1

         */

        #region 第1排

        public static Func<TResult> Compose<TResult>(
            this Func<TResult> exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            this Func<TInput, TResult> exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            this Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            this Func<TInput, TResult> exp2,
            [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            this Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3排

        #endregion exp1 Action  -  exp2 Func
    }
}