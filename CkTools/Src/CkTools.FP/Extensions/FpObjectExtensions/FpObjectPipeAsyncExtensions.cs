using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace System
{
    public static partial class FpObjectPipeAsyncExtensions
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

        #region PipeIfAsync

        /// <summary>
        /// 管道
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static Task<TInput> PipeIfAsync<TInput>(
            this Task<TInput> input,
            bool isExecute,
            [NotNull] Func<TInput, TInput> func)
        {
            func.CheckNullWithException(nameof(func));

            return input.ContinueWith(inObj =>
            {
                if (isExecute)
                {
                    return func(inObj.Result);
                }
                else
                {
                    return inObj.Result;
                }
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static Task<TInput> PipeIfAsync<TInput>(
            this Task<TInput> input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] Func<TInput, TInput> func)
        {
            isExecute.CheckNullWithException(nameof(isExecute));
            func.CheckNullWithException(nameof(func));

            return input.ContinueWith(inObj =>
            {
                if (isExecute(inObj.Result))
                {
                    return func(inObj.Result);
                }
                else
                {
                    return inObj.Result;
                }
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        #endregion PipeIfAsync

        #region TryPipeAsync

        /// <summary>
        /// 管道 <para></para>
        /// a->(a->b) => b <para></para>
        /// 示例： string->(string->int) => int
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// <para><paramref name="defaultValue"/>：发生异常时返回的默认值 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <typeparam name="TOutput">输出类型</typeparam>
        /// <returns></returns>
        public static Task<TOutput> TryPipeAsync<TInput, TOutput>(
            this Task<TInput> input,
            [NotNull] Func<TInput, TOutput> func,
            TOutput defaultValue)
        {
            func.CheckNullWithException(nameof(func));

            return input.ContinueWith(
                t => { try { return func(t.Result); } catch { return defaultValue; } },
                TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        /// <summary>
        /// 管道 <para></para>
        /// a->(a->b) => b <para></para>
        /// 示例： string->(string->int) => int
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// <para><paramref name="handler"/>：异常处理函数 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <typeparam name="TOutput">输出类型</typeparam>
        /// <returns></returns>
        public static Task<TOutput> TryPipeAsync<TInput, TOutput>(
            this Task<TInput> input,
            [NotNull] Func<TInput, TOutput> func,
            Func<TInput, Exception, TOutput> handler)
        {
            func.CheckNullWithException(nameof(func));
            handler.CheckNullWithException(nameof(handler));
            return input.ContinueWith(
                t => { try { return func(t.Result); } catch (Exception ex) { return handler(t.Result, ex); } },
                TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        #endregion TryPipeAsync

        #region TryPipeIfAsync

        /// <summary>
        /// 管道
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// <para><paramref name="handler"/>：异常处理函数</para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static Task<TOutput> TryPipeIfAsync<TInput, TOutput>(
            this Task<TInput> input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] Func<TInput, TOutput> func,
            Func<TInput, Exception, TOutput> handler)
        {
            func.CheckNullWithException(nameof(func));
            handler.CheckNullWithException(nameof(handler));
            return input.ContinueWith(
                t => { try { return func(t.Result); } catch (Exception ex) { return handler(t.Result, ex); } },
                TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        #endregion TryPipeIfAsync
    }
}