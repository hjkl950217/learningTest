using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-组合(柯里化)
    /// </summary>
    public static partial class CkFunctions
    {
        #region Func

        #region 其它

        public static Func<TInput2, TResultEnd> Compose<TInput1, TInput2, TResultEnd>(
            [NotNull] Func<TInput1, Func<TInput2, TResultEnd>> exp2,
            [NotNull] Func<TInput1> exp1)
        {
            CkFunctions.CheckNullWithException(exp2, exp1);
            return exp2(exp1());
        }

        public static Func<TResultEnd> Compose<TInput1, TInput2, TResultEnd>(
            [NotNull] Func<TInput1, Func<TInput2, TResultEnd>> exp3,
            [NotNull] Func<TInput2> exp2,
            [NotNull] Func<TInput1> exp1)
        {
            CkFunctions.CheckNullWithException(exp2, exp1);
            return () => exp3(exp1())(exp2());
        }

        #endregion 其它

        #endregion Func
    }
}