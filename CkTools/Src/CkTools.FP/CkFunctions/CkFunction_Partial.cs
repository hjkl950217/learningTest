using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        public static Action<T1> Partial<T1>(
            Func<T1, Action> exp)
        {
            return x => exp(x);
        }

        public static Action<T1, T2> Partial<T1, T2>(
            Func<T1, Func<T2, Action>> exp)
        {
            return (x, y) => exp(x)(y);
        }

        public static Action<T1, T2, T3> Partial<T1, T2, T3>(
            Func<T1, Func<T2, Func<T3, Action>>> exp)
        {
            return (x, y, z) => exp(x)(y)(z);
        }

        public static Action<T1, T2, T3, T4> Partial<T1, T2, T3, T4>(
            Func<T1, Func<T2, Func<T3, Func<T4, Action>>>> exp)
        {
            return (x, y, z, g) => exp(x)(y)(z)(g);
        }

        #endregion Action

        #region Func

        public static Func<T1, TResult> Partial<T1, TResult>(
            Func<T1, Func<TResult>> exp)
        {
            return x => exp(x)();
        }

        public static Func<T1, T2, TResult> Partial<T1, T2, TResult>(
            Func<T1, Func<T2, Func<TResult>>> exp)
        {
            return (x, y) => exp(x)(y)();
        }

        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, TResult>(
            Func<T1, Func<T2, Func<T3, Func<TResult>>>> exp)
        {
            return (x, y, z) => exp(x)(y)(z)();
        }

        public static Func<T1, T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            Func<T1, Func<T2, Func<T3, Func<T4, Func<TResult>>>>> exp)
        {
            return (x, y, z, g) => exp(x)(y)(z)(g)();
        }

        #endregion Func
    }
}