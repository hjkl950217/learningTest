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
        /// 选择器
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TCenter"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="exp"></param>
        /// <param name="selectExp">选择器，选择执行第几个函数,索引从0开始</param>
        /// <param name="expArray">函数数组</param>
        /// <returns></returns>
        public static Func<TInput, TResult> Switch<TInput, TCenter, TResult>(
          [NotNull] Func<TInput, TCenter> exp,
          [NotNull] Func<TCenter, byte> selectExp,
          [NotNull] params Func<TCenter, TResult>[] expArray)
        {
            CkFunctions.CheckNullWithException(exp, selectExp, expArray);

            return t => exp(t).Pipe(c => expArray[selectExp(c)](c));
        }
    }
}