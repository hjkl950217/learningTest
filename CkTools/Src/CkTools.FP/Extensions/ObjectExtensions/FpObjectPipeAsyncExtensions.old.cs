//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Tasks;

//namespace System
//{
//    public static partial class FpObjectPipeAsyncExtensions
//    {
//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="input"/>：要处理的值 </para>
//        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
//        /// <para><paramref name="func"/>：将要执行的处理 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <returns></returns>
//        [Obsolete("PipeAsync")]
//        public static Task<TInput> PipeAsync<TInput>(
//            this Task<TInput> input,
//            bool isExecute,
//            [NotNull] Func<TInput, TInput> func
//            )
//        {
//            return FpObjectPipeAsyncExtensions.PipeIfAsync(input, isExecute, func);
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="input"/>：要处理的值 </para>
//        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
//        /// <para><paramref name="func"/>：将要执行的处理 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <returns></returns>
//        [Obsolete("PipeAsync")]
//        public static Task<TInput> PipeAsync<TInput>(
//            this Task<TInput> input,
//            [NotNull] Func<TInput, bool> isExecute,
//            [NotNull] Func<TInput, TInput> func
//            )
//        {
//            return FpObjectPipeAsyncExtensions.PipeIfAsync(input, isExecute, func);
//        }
//    }
//}