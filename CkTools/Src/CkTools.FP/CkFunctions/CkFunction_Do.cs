using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    /// <remarks>
    /// 基础组合与 Compose 的功能一样，这个文件相当于多写了一个命名
    /// 在“其他”里增加了一些特色方法
    /// </remarks>
    public static partial class CkFunctions
    {
        #region Action

        /*
         竖exp1\横exp2    Action     Action<T>   Action<T2,T1>
         Action             1           1          1
         Action<T>          1           1          2
         Action<T2,T1>      1           x          1
         */

        #region 第1排

        public static Action Do(
            [NotNull] Action exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Do<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Action<TInput> Do<TInput>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput> Do<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput, TInput> Do<TInput>(
           [NotNull] Action<TInput, TInput> exp2,
           [NotNull] Action<TInput> exp1)
        {
            return CkFunctions.Compose<TInput>(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return CkFunctions.Compose(exp2, exp1);
        }

        #endregion 第3排

        #region 其他

        public static Action Do(
            [NotNull] Action exp5,
            [NotNull] Action exp4,
            [NotNull] Action exp3,
            [NotNull] Action? exp2 = null,
            [NotNull] Action? exp1 = null)
        {
#pragma warning disable CS8777 // 退出时，参数必须具有非 null 值。
            return CkFunctions.Compose(exp5, exp4, exp3, exp2, exp1);
#pragma warning restore CS8777 // 退出时，参数必须具有非 null 值。
        }

        public static Action<TInput> Do<TInput>(
            [NotNull] Action<TInput> exp5,
            [NotNull] Action<TInput> exp4,
            [NotNull] Action<TInput> exp3,
            [NotNull] Action<TInput>? exp2 = null,
            [NotNull] Action<TInput>? exp1 = null)
        {
#pragma warning disable CS8777 // 退出时，参数必须具有非 null 值。
            return CkFunctions.Compose(exp5, exp4, exp3, exp2, exp1);
#pragma warning restore CS8777 // 退出时，参数必须具有非 null 值。
        }

        #endregion 其他

        #endregion Action

        #region Func

        /*
         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
         Func<TR>           x               x              x
         Func<T,TR>         x               x              x
         Func<T2,T1,TR>     x               x              x
         */

        #region 其他

        public static Func<TResult> Do<TResult>(
            [NotNull] Func<TResult> exp5,
            [NotNull] Action exp4,
            [NotNull] Action exp3,
            [NotNull] Action? exp2 = null,
            [NotNull] Action? exp1 = null)
        {
            Action action = CkFunctions.Compose(exp4, exp3, exp2, exp1);
#pragma warning disable CS8777 // 退出时，参数必须具有非 null 值。
            return CkFunctions.Compose(exp5, action);
#pragma warning restore CS8777 // 退出时，参数必须具有非 null 值。
        }

        public static Func<TInput, TResult> Do<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp5,
            [NotNull] Action exp4,
            [NotNull] Action exp3,
            [NotNull] Action? exp2 = null,
            [NotNull] Action? exp1 = null)
        {
            Action action = CkFunctions.Compose(exp4, exp3, exp2, exp1);
#pragma warning disable CS8777 // 退出时，参数必须具有非 null 值。
            return CkFunctions.Compose(exp5, action);
#pragma warning restore CS8777 // 退出时，参数必须具有非 null 值。
        }

        public static Func<TInput, TResult> Do<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp5,
            [NotNull] Action<TInput> exp4,
            [NotNull] Action<TInput> exp3,
            [NotNull] Action<TInput>? exp2 = null,
            [NotNull] Action<TInput>? exp1 = null)
        {
            Action<TInput> action = CkFunctions.Compose(exp4, exp3, exp2, exp1);
#pragma warning disable CS8777 // 退出时，参数必须具有非 null 值。
            return CkFunctions.Compose(exp5, action);
#pragma warning restore CS8777 // 退出时，参数必须具有非 null 值。
        }

        #endregion 其他

        #endregion Func

        #region exp1 Func  -  exp2 Action

        /*
         竖exp1\横exp2    Action     Action<TR>   Action<T2,T1>
         Func<TR>           1           1           x
         Func<T,TR>         1           1           x
         Func<T2,T1,TR>     1           1           x

         */

        #region 第1排

        public static Func<TResult> Do<TResult>(
         [NotNull] Action exp2,
         [NotNull] Func<TResult> exp1)
        {
            return Compose(exp2, exp1);
        }

        public static Func<TResult> Do<TResult>(
            [NotNull] Action<TResult> exp2,
            [NotNull] Func<TResult> exp1)
        {
            return Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Func<TInput, TResult> Do<TInput, TResult>(
            [NotNull] Action exp2,
            [NotNull] Func<TInput, TResult> exp1)
        {
            return Compose(exp2, exp1);
        }

        public static Func<TInput, TResult> Do<TInput, TResult>(
            [NotNull] Action<TResult> exp2,
            [NotNull] Func<TInput, TResult> exp1)
        {
            return Compose(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
            [NotNull] Action exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            return Compose(exp2, exp1);
        }

        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
            [NotNull] Action<TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            return Compose(exp2, exp1);
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

        public static Func<TResult> Do<TResult>(
            [NotNull] Func<TResult> exp2,
            [NotNull] Action exp1)
        {
            return Compose(exp2, exp1);
        }

        public static Func<TInput, TResult> Do<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp2,
            [NotNull] Action exp1)
        {
            return Compose(exp2, exp1);
        }

        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action exp1)
        {
            return Compose(exp2, exp1);
        }

        #endregion 第1排

        #region 第2排

        public static Func<TInput, TResult> Do<TInput, TResult>(
             [NotNull] Func<TInput, TResult> exp2,
             [NotNull] Action<TInput> exp1)
        {
            return Compose(exp2, exp1);
        }

        #endregion 第2排

        #region 第3排

        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            return Compose(exp2, exp1);
        }

        #endregion 第3排

        #endregion exp1 Action  -  exp2 Func
    }
}