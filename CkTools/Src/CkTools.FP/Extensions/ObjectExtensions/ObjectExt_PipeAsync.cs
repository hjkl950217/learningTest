using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace System
{
    /// <summary>
    /// 从对象上面直接调用的FP方法
    /// </summary>
    public static class ObjectExt_PipeAsync
    {
        #region PipeAsync

        /// <summary>
        /// 管道 <para></para>
        /// a->(a->b) => b <para></para>
        /// 示例： string->(string->int) => int
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <typeparam name="TOutput">输出类型</typeparam>
        /// <returns></returns>
        public static Task<TOutput> PipeAsync<TInput, TOutput>(
            this Task<TInput> input,
            [NotNull] Func<TInput, TOutput> func)
        {
            func.CheckNullWithException(nameof(func));
            return input.ContinueWith(t => func(t.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        #endregion PipeAsync
    }
}