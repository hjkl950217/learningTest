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

        public static void CheckNullWithException<T>(params T[] exps)
            where T : class
        {
            if (exps == null) throw new ArgumentNullException(nameof(exps));
            foreach (T? exp in exps)
            {
                if (exp == null) throw new ArgumentNullException(nameof(exp));
            }
        }

        public static void CheckNullWithException<T5, T4, T3, T2, T1>(T5 exp5, T4 exp4, T3 exp3, T2 exp2, T1 exp1)
            where T5 : class?
            where T4 : class?
            where T3 : class?
            where T2 : class?
            where T1 : class?
        {
            if (exp1 == null) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null) throw new ArgumentNullException(nameof(exp2));
            if (exp3 == null) throw new ArgumentNullException(nameof(exp3));
            if (exp4 == null) throw new ArgumentNullException(nameof(exp4));
            if (exp5 == null) throw new ArgumentNullException(nameof(exp5));
        }

        public static void CheckNullWithException<T4, T3, T2, T1>(T4 exp4, T3 exp3, T2 exp2, T1 exp1)

            where T4 : class?
            where T3 : class?
            where T2 : class?
            where T1 : class?
        {
            if (exp1 == null) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null) throw new ArgumentNullException(nameof(exp2));
            if (exp3 == null) throw new ArgumentNullException(nameof(exp3));
            if (exp4 == null) throw new ArgumentNullException(nameof(exp4));
        }

        public static void CheckNullWithException<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : class?
            where T2 : class?
            where T1 : class?
        {
            if (exp1 == null) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null) throw new ArgumentNullException(nameof(exp2));
            if (exp3 == null) throw new ArgumentNullException(nameof(exp3));
        }

        public static void CheckNullWithException<T2, T1>(T2 exp2, T1 exp1)
            where T2 : class?
            where T1 : class?
        {
            if (exp1 == null) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null) throw new ArgumentNullException(nameof(exp2));
        }

        public static void CheckNullWithException<T1>(T1 exp1)
            where T1 : class?
        {
            if (exp1 == null) throw new ArgumentNullException(nameof(exp1));
        }

        #endregion CheckNullWithException

        #region CheckNullOrEmpty

        public static void CheckNullOrEmptyWithException<T>(params T[] exps)
            where T : IEnumerable
        {
            if (exps == null || !exps.Any()) throw new ArgumentNullException(nameof(exps));
            foreach (IEnumerable exp in exps)
            {
                if (exp == null || !exp.Any()) throw new ArgumentNullException(nameof(exp));
            }
        }

        public static void CheckNullOrEmptyWithException<T5, T4, T3, T2, T1>(T5 exp5, T4 exp4, T3 exp3, T2 exp2, T1 exp1)
            where T5 : IEnumerable
            where T4 : IEnumerable
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null || !exp2.Any()) throw new ArgumentNullException(nameof(exp2));
            if (exp3 == null || !exp3.Any()) throw new ArgumentNullException(nameof(exp3));
            if (exp4 == null || !exp4.Any()) throw new ArgumentNullException(nameof(exp4));
            if (exp5 == null || !exp5.Any()) throw new ArgumentNullException(nameof(exp5));
        }

        public static void CheckNullOrEmptyWithException<T4, T3, T2, T1>(T4 exp4, T3 exp3, T2 exp2, T1 exp1)

            where T4 : IEnumerable
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null || !exp2.Any()) throw new ArgumentNullException(nameof(exp2));
            if (exp3 == null || !exp3.Any()) throw new ArgumentNullException(nameof(exp3));
            if (exp4 == null || !exp4.Any()) throw new ArgumentNullException(nameof(exp4));
        }

        public static void CheckNullOrEmptyWithException<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null || !exp2.Any()) throw new ArgumentNullException(nameof(exp2));
            if (exp3 == null || !exp3.Any()) throw new ArgumentNullException(nameof(exp3));
        }

        public static void CheckNullOrEmptyWithException<T2, T1>(T2 exp2, T1 exp1)
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) throw new ArgumentNullException(nameof(exp1));
            if (exp2 == null || !exp2.Any()) throw new ArgumentNullException(nameof(exp2));
        }

        public static void CheckNullOrEmptyWithException<T1>(T1 exp1)
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) throw new ArgumentNullException(nameof(exp1));
        }

        #endregion CheckNullOrEmpty

        #region IsNull

        public static bool IsNull<T>(params T[] exps)
        {
            return exps == null || exps.Any(t => t == null);
        }

        public static bool IsNull<T5, T4, T3, T2, T1>(T5 exp5, T4 exp4, T3 exp3, T2 exp2, T1 exp1)
        {
            return exp1 == null || exp2 == null || exp3 == null || exp4 == null || exp5 == null;
        }

        public static bool IsNull<T4, T3, T2, T1>(T4 exp4, T3 exp3, T2 exp2, T1 exp1)
        {
            return exp1 == null || exp2 == null || exp3 == null || exp4 == null;
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
            return !IsNull(exps);
        }

        public static bool IsNotNull<T5, T4, T3, T2, T1>(T5 exp5, T4 exp4, T3 exp3, T2 exp2, T1 exp1)
        {
            return !IsNull(exp5, exp4, exp3, exp2, exp1);
        }

        public static bool IsNotNull<T4, T3, T2, T1>(T4 exp4, T3 exp3, T2 exp2, T1 exp1)
        {
            return !IsNull(exp4, exp3, exp2, exp1);
        }

        public static bool IsNotNull<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
        {
            return !IsNull(exp3, exp2, exp1);
        }

        public static bool IsNotNull<T2, T1>(T2 exp2, T1 exp1)
        {
            return !IsNull(exp1);
        }

        public static bool IsNotNull<T1>(T1 exp1)
        {
            return !IsNull(exp1);
        }

        #endregion IsNotNull

        #region IsNullOrEmpty

        public static bool IsNullOrEmpty<T>(params T[] exps)
            where T : IEnumerable
        {
            return exps == null || !exps.Any()
                || exps.Any(t => t == null || !t.Any());
        }

        public static bool IsNullOrEmpty<T5, T4, T3, T2, T1>(T5 exp5, T4 exp4, T3 exp3, T2 exp2, T1 exp1)
            where T5 : IEnumerable
            where T4 : IEnumerable
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) return true;
            if (exp2 == null || !exp2.Any()) return true;
            if (exp3 == null || !exp3.Any()) return true;
            if (exp4 == null || !exp4.Any()) return true;
            if (exp5 == null || !exp5.Any()) return true;
            return false;
        }

        public static bool IsNullOrEmpty<T4, T3, T2, T1>(T4 exp4, T3 exp3, T2 exp2, T1 exp1)

            where T4 : IEnumerable
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) return true;
            if (exp2 == null || !exp2.Any()) return true;
            if (exp3 == null || !exp3.Any()) return true;
            if (exp4 == null || !exp4.Any()) return true;

            return false;
        }

        public static bool IsNullOrEmpty<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) return true;
            if (exp2 == null || !exp2.Any()) return true;
            if (exp3 == null || !exp3.Any()) return true;
            return false;
        }

        public static bool IsNullOrEmpty<T2, T1>(T2 exp2, T1 exp1)
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) return true;
            if (exp2 == null || !exp2.Any()) return true;
            return false;
        }

        public static bool IsNullOrEmpty<T1>(T1 exp1)
            where T1 : IEnumerable
        {
            if (exp1 == null || !exp1.Any()) return true;
            return false;
        }

        #endregion IsNullOrEmpty

        #region IsNotNullOrEmpty

        public static bool IsNotNullOrEmpty<T>(params T[] exps)
            where T : IEnumerable
        {
            return !IsNullOrEmpty(exps);
        }

        public static bool IsNotNullOrEmpty<T5, T4, T3, T2, T1>(T5 exp5, T4 exp4, T3 exp3, T2 exp2, T1 exp1)
            where T5 : IEnumerable
            where T4 : IEnumerable
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable

        {
            return !IsNullOrEmpty(exp5, exp4, exp3, exp2, exp1);
        }

        public static bool IsNotNullOrEmpty<T4, T3, T2, T1>(T4 exp4, T3 exp3, T2 exp2, T1 exp1)
              where T4 : IEnumerable
              where T3 : IEnumerable
              where T2 : IEnumerable
              where T1 : IEnumerable

        {
            return !IsNullOrEmpty(exp4, exp3, exp2, exp1);
        }

        public static bool IsNotNullOrEmpty<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : IEnumerable
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            return !IsNullOrEmpty(exp3, exp2, exp1);
        }

        public static bool IsNotNullOrEmpty<T2, T1>(T2 exp2, T1 exp1)
            where T2 : IEnumerable
            where T1 : IEnumerable
        {
            return !IsNullOrEmpty(exp2, exp1);
        }

        public static bool IsNotNullOrEmpty<T1>(T1 exp1)
            where T1 : IEnumerable
        {
            return !IsNullOrEmpty(exp1);
        }

        #endregion IsNotNullOrEmpty
    }
}