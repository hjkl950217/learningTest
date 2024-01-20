using CkTools.FP;

namespace System
{
    /// <summary>
    /// 函数式扩展-分布函数
    /// </summary>
    public static class FP_Partial_Extensions
    {
        #region Action

        public static Action<T1, T2> Partial<T1, T2>(
            this Func<T1, Action<T2>> exp)
        {
            return CkFunctions.Partial(exp);
        }

        public static Action<T1, T2, T3> Partial<T1, T2, T3>(
            this Func<T1, Func<T2, Action<T3>>> exp)
        {
            return CkFunctions.Partial(exp);
        }

        public static Action<T1, T2, T3, T4> Partial<T1, T2, T3, T4>(
            this Func<T1, Func<T2, Func<T3, Action<T4>>>> exp)
        {
            return CkFunctions.Partial(exp);
        }

        #endregion Action

        #region Func

        public static Func<T1, TResult> Partial<T1, TResult>(
            this Func<T1, TResult> exp)
        {
            return CkFunctions.Partial(exp);
        }

        public static Func<T1, T2, TResult> Partial<T1, T2, TResult>(
            this Func<T1, Func<T2, TResult>> exp)
        {
            return CkFunctions.Partial(exp);
        }

        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, TResult>(
            this Func<T1, Func<T2, Func<T3, TResult>>> exp)
        {
            return CkFunctions.Partial(exp);
        }

        public static Func<T1, T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> exp)
        {
            return CkFunctions.Partial(exp);
        }

        #endregion Func
    }
}