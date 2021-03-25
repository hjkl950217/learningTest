﻿using CkTools.FP;

namespace System
{
    /// <summary>
    /// 函数式扩展-柯里化
    /// </summary>
    public static class FP_Currying_Extensions
    {
        #region Action

        public static Func<T1, Action> Currying<T1>(
            this Action<T1> exp)
        {
            return CkFunctions.Currying(exp);
        }

        public static Func<T1, Func<T2, Action>> Currying<T1, T2>(
            this Action<T1, T2> exp)
        {
            return CkFunctions.Currying(exp);
        }

        public static Func<T1, Func<T2, Func<T3, Action>>> Currying<T1, T2, T3>(
            this Action<T1, T2, T3> exp)
        {
            return CkFunctions.Currying(exp);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Action>>>> Currying<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> exp)
        {
            return CkFunctions.Currying(exp);
        }

        #endregion Action

        #region Func

        public static Func<T1, Func<TResult>> Currying<T1, TResult>(
            this Func<T1, TResult> exp)
        {
            return CkFunctions.Currying(exp);
        }

        public static Func<T1, Func<T2, Func<TResult>>> Currying<T1, T2, TResult>(
            this Func<T1, T2, TResult> exp)
        {
            return CkFunctions.Currying(exp);
        }

        public static Func<T1, Func<T2, Func<T3, Func<TResult>>>> Currying<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> exp)
        {
            return CkFunctions.Currying(exp);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<TResult>>>>> Currying<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> exp)
        {
            return CkFunctions.Currying(exp);
        }

        #endregion Func
    }
}