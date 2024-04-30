//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Tasks;
//using CkTools.FP;

//namespace System
//{
//    /// <summary>
//    /// 从对象上面直接调用的FP方法
//    /// </summary>
//    public static class ObjectExt_TryPipeAsync
//    {
//        #region TryPipeAsync

//        /// <summary>
//        /// 管道 <para></para>
//        /// a->(a->b) => b <para></para>
//        /// 示例： string->(string->int) => int
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="input"/>：要处理的值 </para>
//        /// <para><paramref name="func"/>：将要执行的处理 </para>
//        /// <para><paramref name="defaultValue"/>：发生异常时返回的默认值 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <typeparam name="TOutput">输出类型</typeparam>
//        /// <returns></returns>
//        public static Task<TOutput> TryPipeAsync<TInput, TOutput>(
//            this Task<TInput> input,
//            [NotNull] Func<TInput, TOutput> func,
//            TOutput defaultValue)
//        {
//            CkFunctions.CheckNullWithException(func);

//            return input.ContinueWith(
//                t => { try { return func(t.Result); } catch { return defaultValue; } },
//                TaskContinuationOptions.OnlyOnRanToCompletion);
//        }

//        /// <summary>
//        /// 管道 <para></para>
//        /// a->(a->b) => b <para></para>
//        /// 示例： string->(string->int) => int
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="input"/>：要处理的值 </para>
//        /// <para><paramref name="func"/>：将要执行的处理 </para>
//        /// <para><paramref name="handler"/>：异常处理函数 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <typeparam name="TOutput">输出类型</typeparam>
//        /// <returns></returns>
//        public static Task<TOutput> TryPipeAsync<TInput, TOutput>(
//            this Task<TInput> input,
//            [NotNull] Func<TInput, TOutput> func,
//            Func<TInput, Exception, TOutput> handler)
//        {
//            CkFunctions.CheckNullWithException(handler, func);

//            return input.ContinueWith(
//                t => { try { return func(t.Result); } catch(Exception ex) { return handler(t.Result, ex); } },
//                TaskContinuationOptions.OnlyOnRanToCompletion);
//        }

//        #endregion TryPipeAsync
//    }
//}