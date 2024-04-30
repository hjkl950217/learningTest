using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 从对象上面直接调用的FP方法
    /// </summary>
    public static class ObjectExt_Do
    {
        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="doFuncs"/>：将要执行的处理集合 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput Do<TInput>(
            this TInput input,
            [NotNull] params Action[] doFuncs)
        {
            CkFunctions.CheckNullWithException(doFuncs);
            CkFunctions.ComposeReverse(doFuncs)();
            return input;
        }

        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="doFuncs"/>：将要执行的处理集合 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput Do<TInput>(
            this TInput input,
            [NotNull] params Action<TInput>[] doFuncs)
        {
            CkFunctions.CheckNullWithException(doFuncs);
            CkFunctions.ComposeReverse(doFuncs)(input);
            return input;
        }
    }
}