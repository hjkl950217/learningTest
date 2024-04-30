using System.Diagnostics.CodeAnalysis;

namespace System
{
    /// <summary>
    /// 从对象上面直接调用的FP方法
    /// </summary>
    /// <remarks>
    /// PipeIf的镜像
    /// </remarks>
    public static class ObjectExt_DoIf
    {
        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="doFuncs"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput DoIf<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] params Action[] doFuncs)
        {
            return ObjectExt_PipeIf.PipeIf<TInput>(input, isExecute, doFuncs);
        }

        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，true为执行 </para>
        /// <para><paramref name="doFuncs"/>：将要执行的处理集合 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput DoIf<TInput>(
            this TInput input,
            [NotNull] bool isExecute,
            [NotNull] params Action[] doFuncs)
        {
            return ObjectExt_PipeIf.PipeIf(input, t => isExecute, doFuncs);
        }

        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="doFuncs"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput DoIf<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] params Action<TInput>[] doFuncs)
        {
            return ObjectExt_PipeIf.PipeIf<TInput>(input, isExecute, doFuncs);
        }

        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，true为执行 </para>
        /// <para><paramref name="doFuncs"/>：将要执行的处理集合 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput DoIf<TInput>(
            this TInput input,
            [NotNull] bool isExecute,
            [NotNull] params Action<TInput>[] doFuncs)
        {
            return ObjectExt_PipeIf.PipeIf<TInput>(input, isExecute, doFuncs);
        }
    }
}