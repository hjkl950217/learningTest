//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Tasks;
//using CkTools.FP;

//namespace System
//{
//    /// <summary>
//    /// 从对象上面直接调用的FP方法
//    /// </summary>
//    public static class ObjectExt_TryPipeIfAsync
//    {
//        #region TryPipeIfAsync

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="input"/>：要处理的值 </para>
//        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
//        /// <para><paramref name="func"/>：将要执行的处理 </para>
//        /// <para><paramref name="handler"/>：异常处理函数</para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <returns></returns>
//        public static Task<TOutput> TryPipeIfAsync<TInput, TOutput>(
//            this Task<TInput> input,
//            [NotNull] Func<TInput, bool> isExecute,
//            [NotNull] Func<TInput, TOutput> func,
//            Func<TInput, Exception, TOutput> handler)
//        {
//            CkFunctions.CheckNullWithException(handler, func);
//            return input.ContinueWith(
//                t => { try { return func(t.Result); } catch (Exception ex) { return handler(t.Result, ex); } },
//                TaskContinuationOptions.OnlyOnRanToCompletion);
//        }

//        #endregion TryPipeIfAsync
//    }
//}