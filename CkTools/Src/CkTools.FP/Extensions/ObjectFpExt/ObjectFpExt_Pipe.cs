using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    public static class ObjectExt_Pipe
    {
        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="sourceObject">源对象</param>
        /// <param name="actions">要执行的操作集合</param>
        /// <returns></returns>
        public static TInput Pipe<TInput>(
            this TInput sourceObject,
            [NotNull] params Action[] actions)
        {
            CkFunctions.CheckNullWithException(actions);

            CkFunctions.ComposeReverse(actions)();
            return sourceObject;
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="sourceObject">源对象</param>
        /// <param name="actions">要执行的操作集合</param>
        /// <returns></returns>
        public static TInput Pipe<TInput>(
            this TInput sourceObject,
            [NotNull] params Action<TInput>[] actions)
        {
            CkFunctions.CheckNullWithException(actions);
            CkFunctions.ComposeReverse(actions)(sourceObject);
            return sourceObject;
        }

        /// <summary>
        /// 管道
        /// </summary>
        /// <Value>
        /// <para><paramref name="sourceObject"/>：要处理的值 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <typeparam name="TOutput">输出类型</typeparam>
        /// <returns></returns>
        public static TOutput Pipe<TInput, TOutput>(
            this TInput sourceObject,
            [NotNull] Func<TInput, TOutput> func)
        {
            CkFunctions.CheckNullWithException(func);
            return func(sourceObject);
        }
    }
}