using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-分部函数
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        public static Action<T1> Partial<T1>(
            Action<T1> exp)
        {
            return exp;//这个函数是为了方便将对象的方法转换为委托
        }

        public static Action<T1, T2> Partial<T1, T2>(
            Func<T1, Action<T2>> exp)
        {
            return (x, y) => exp(x)(y);
        }

        public static Action<T1, T2, T3> Partial<T1, T2, T3>(
            Func<T1, Func<T2, Action<T3>>> exp)
        {
            return (x, y, z) => exp(x)(y)(z);
        }

        public static Action<T1, T2, T3, T4> Partial<T1, T2, T3, T4>(
            Func<T1, Func<T2, Func<T3, Action<T4>>>> exp)
        {
            return (x, y, z, g) => exp(x)(y)(z)(g);
        }

        #endregion Action

        #region Func

        public static Func<T1, TResult> Partial<T1, TResult>(
            Func<T1, TResult> exp)
        {
            return exp;//这个函数是为了方便将对象的方法转换为委托
        }

        public static Func<T1, T2, TResult> Partial<T1, T2, TResult>(
            Func<T1, Func<T2, TResult>> exp)
        {
            return (x, y) => exp(x)(y);
        }

        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, TResult>(
            Func<T1, Func<T2, Func<T3, TResult>>> exp)
        {
            return (x, y, z) => exp(x)(y)(z);
        }

        public static Func<T1, T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> exp)
        {
            return (x, y, z, g) => exp(x)(y)(z)(g);
        }

        #endregion Func
    }
}