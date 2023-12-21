using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 从对象上面直接调用的FP方法
    /// </summary>
    public static class ObjectExt_PipeIfAsync
    {
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
            CkFunctions.CheckNullWithException(func);

            return input.ContinueWith(inObj =>
            {
                if(isExecute)
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
            CkFunctions.CheckNullWithException(isExecute, func);

            return input.ContinueWith(inObj =>
            {
                if(isExecute(inObj.Result))
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
    }
}