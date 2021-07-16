using System;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        public static void CheckNull<T1>(T1 exp1)

            where T1 : class
        {
            exp1.CheckNullWithException(nameof(exp1));
        }

        public static void CheckNull<T2, T1>(T2 exp2, T1 exp1)
            where T2 : class
            where T1 : class
        {
            exp2.CheckNullWithException(nameof(exp2));
            exp1.CheckNullWithException(nameof(exp1));
        }

        public static void CheckNull<T3, T2, T1>(T3 exp3, T2 exp2, T1 exp1)
            where T3 : class
            where T2 : class
            where T1 : class
        {
            exp3.CheckNullWithException(nameof(exp3));
            exp2.CheckNullWithException(nameof(exp2));
            exp1.CheckNullWithException(nameof(exp1));
        }

        public static void CheckNull(params object[] exps)
        {
            exps.CheckNullWithException(nameof(exps));
            foreach (object? exp in exps)
            {
                exp.CheckNullWithException(nameof(exp));
            }
        }
    }
}