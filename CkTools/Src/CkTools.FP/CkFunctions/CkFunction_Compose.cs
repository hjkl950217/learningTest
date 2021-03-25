using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        /// <summary>
        /// 结合
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TCenter"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp2"></param>
        /// <param name="exp1"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Compose<TInput, TCenter, TResult>(
            [NotNull] Func<TCenter, TResult> exp2,
            [NotNull] Func<TInput, TCenter> exp1)
        {
            return CkFunctions.Pipe(exp1, exp2);
        }
    }
}