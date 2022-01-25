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
        /// Try
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp"/>：要执行的函数 </para>
        /// <para><paramref name="exEXP"/>：异常处理函数,需要返回发生异常时的返回值</para>
        /// </Value>
        /// <typeparam name="TOutput">输出类型参数</typeparam>
        /// <returns></returns>
        public static Func<TOutput> TryWithThrow<TOutput>(
            [NotNull] Func<TOutput> exp,
            [NotNull] Action<Exception> exEXP)
        {
            return CkFunctions.Try(exp, ex => { exEXP(ex); throw ex; });
        }
    }
}
