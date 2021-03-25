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
        public static TInput PipeIf<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] Func<TInput, TInput> func
            )
        {
            isExecute.CheckNullWithException(nameof(isExecute));
            func.CheckNullWithException(nameof(func));

            if (isExecute(input))
            {
                return func(input);
            }
            else
            {
                return input;
            }
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
        public static TInput PipeIf<TInput>(
            this TInput input,
            bool isExecute,
            Func<TInput, TInput> func)
        {
            return input.PipeIf(t => isExecute, func);
        }

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
        public static TOutput Pipe<TInput, TOutput>(
            this TInput input,
            [NotNull] Func<TInput, TOutput> func
            )
        {
            func.CheckNullWithException(nameof(func));

            return func(input);
        }
    }
}