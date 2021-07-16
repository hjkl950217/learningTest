using System;
using System.Collections;
using System.Linq;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region CheckNullWithException

        public static void CheckNullWithException<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : class
            where T2 : class
            where T1 : class
        {
            exp3.CheckNullWithException(nameof(exp3));
            exp2.CheckNullWithException(nameof(exp2));
            exp1.CheckNullWithException(nameof(exp1));
        }

        public static void CheckNullWithException<T2, T1>(T2 exp2, T1 exp1)
            where T2 : class
            where T1 : class
        {
            exp2.CheckNullWithException(nameof(exp2));
            exp1.CheckNullWithException(nameof(exp1));
        }

        public static void CheckNullWithException<T1>(T1 exp1)
            where T1 : class
        {
            exp1.CheckNullWithException(nameof(exp1));
        }

        public static void CheckNullWithException(params object[] exps)
        {
            exps.CheckNullWithException(nameof(exps));
            foreach (object? exp in exps)
            {
                exp.CheckNullWithException(nameof(exp));
            }
        }

        #endregion CheckNullWithException

        #region CheckNullOrEmpty

        public static void CheckNullOrEmptyWithException<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            exp1.CheckNullOrEmptyWithException(nameof(exp1));
        }

        public static void CheckNullOrEmptyWithException<T2, T1>(T2 exp2, T1 exp1)

            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            exp1.CheckNullOrEmptyWithException(nameof(exp1));
        }

        public static void CheckNullOrEmptyWithException<T1>(T1 exp1)
            where T1 : IEnumerable
        {
            exp1.CheckNullOrEmptyWithException(nameof(exp1));
        }

        public static void CheckNullOrEmptyWithException<T>(params T[] exps)
            where T : IEnumerable
        {
            exps.CheckNullOrEmptyWithException(nameof(exps));
            foreach (IEnumerable exp in exps)
            {
                exp.CheckNullOrEmptyWithException(nameof(exp));
            }
        }

        #endregion CheckNullOrEmpty

        #region IsNull

        public static bool IsNull<T>(params T[] exps)
        {
            return exps == null || exps.Any(t => t == null);
        }

        public static bool IsNull<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
        {
            return exp1 == null || exp2 == null || exp3 == null;
        }

        public static bool IsNull<T2, T1>(T2 exp2, T1 exp1)
        {
            return exp1 == null || exp2 == null;
        }

        public static bool IsNull<T1>(T1 exp1)
        {
            return exp1 == null;
        }

        #endregion IsNull

        #region IsNotNull

        public static bool IsNotNull<T>(params T[] exps)
        {
            return exps != null && exps.All(t => t != null);
        }

        public static bool IsNotNull<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
        {
            return exp1 != null && exp2 != null && exp3 != null;
        }

        public static bool IsNotNull<T2, T1>(T2 exp2, T1 exp1)
        {
            return exp1 != null && exp2 != null;
        }

        public static bool IsNotNull<T1>(T1 exp1)
        {
            return exp1 != null;
        }

        #endregion IsNotNull

        #region IsNullOrEmpty

        public static bool IsNullOrEmpty<T>(params T[] exps)
            where T : IEnumerable
        {
            return exps.IsNullOrEmpty() || exps.Any(t => t.IsNullOrEmpty());
        }

        public static bool IsNullOrEmpty<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            return exp1.IsNullOrEmpty() || exp2.IsNullOrEmpty() || exp3.IsNullOrEmpty();
        }

        public static bool IsNullOrEmpty<T2, T1>(T2 exp2, T1 exp1)
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            return exp1.IsNullOrEmpty() || exp2.IsNullOrEmpty();
        }

        public static bool IsNullOrEmpty<T1>(T1 exp1)
            where T1 : IEnumerable
        {
            return exp1.IsNullOrEmpty();
        }

        #endregion IsNullOrEmpty

        #region IsNotNullOrEmpty

        public static bool IsNotNullOrEmpty<T>(params T[] exps)
            where T : IEnumerable
        {
            return exps.IsNotNullOrEmpty() && exps.All(t => t.IsNotNullOrEmpty());
        }

        public static bool IsNotNullOrEmpty<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            return exp1.IsNotNullOrEmpty() && exp2.IsNotNullOrEmpty() && exp3.IsNotNullOrEmpty();
        }

        public static bool IsNotNullOrEmpty<T2, T1>(T2 exp2, T1 exp1)
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            return exp1.IsNotNullOrEmpty() && exp2.IsNotNullOrEmpty();
        }

        public static bool IsNotNullOrEmpty<T1>(T1 exp1)
            where T1 : IEnumerable
        {
            return exp1.IsNotNullOrEmpty();
        }

        #endregion IsNotNullOrEmpty
    }
}