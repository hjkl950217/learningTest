﻿using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        public static Func<T1, Action> Currying<T1>(
             Action<T1> exp)
        {
            return x => () => exp(x);
        }

        public static Func<T1, Func<T2, Action>> Currying<T1, T2>(
             Action<T1, T2> exp)
        {
            return x => y => () => exp(x, y);
        }

        public static Func<T1, Func<T2, Func<T3, Action>>> Currying<T1, T2, T3>(
             Action<T1, T2, T3> exp)
        {
            return x => y => z => () => exp(x, y, z);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Action>>>> Currying<T1, T2, T3, T4>(
             Action<T1, T2, T3, T4> exp)
        {
            return x => y => z => g => () => exp(x, y, z, g);
        }

        #endregion Action

        #region Func

        public static Func<T1, Func<TResult>> Currying<T1, TResult>(
             Func<T1, TResult> exp)
        {
            return x => () => exp(x);
        }

        public static Func<T1, Func<T2, Func<TResult>>> Currying<T1, T2, TResult>(
             Func<T1, T2, TResult> exp)
        {
            return x => y => () => exp(x, y);
        }

        public static Func<T1, Func<T2, Func<T3, Func<TResult>>>> Currying<T1, T2, T3, TResult>(
             Func<T1, T2, T3, TResult> exp)
        {
            return x => y => z => () => exp(x, y, z);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<TResult>>>>> Currying<T1, T2, T3, T4, TResult>(
             Func<T1, T2, T3, T4, TResult> exp)
        {
            return x => y => z => g => () => exp(x, y, z, g);
        }

        #endregion Func

        //todo: 后续还有东西没理解：https://zhuanlan.zhihu.com/p/94591842
    }
}