using System.Diagnostics.CodeAnalysis;

namespace System
{
    public static partial class FpObjectPipeExtensions
    {
        /// <summary>
        /// 管道 <para></para>
        /// a->(a->bool)->(b->c) => c <para></para>
        /// 示例： string->(string->bool)->(string->int) => int
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        [Obsolete("请改用PipeIf")]
        public static TInput Pipe<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] Func<TInput, TInput> func
            )
        {
            return FpObjectPipeExtensions.PipeIf(input, isExecute, func);
        }

        /// <summary>
        /// 管道 <para></para>
        /// a->(()->bool)->(b->c) => c <para></para>
        /// 示例： string->(string->bool)->(string->int) => int
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        [Obsolete("请改用PipeIf")]
        public static TInput Pipe<TInput>(
            this TInput input,
            bool isExecute,
            Func<TInput, TInput> func)
        {
            return FpObjectPipeExtensions.PipeIf(input, t => isExecute, func);
        }
    }
}