using System.Diagnostics.CodeAnalysis;

namespace System
{
    /// <summary>
    /// 从对象上面直接调用的FP方法
    /// </summary>
    public static partial class FpObjectDoExtensions
    {
        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="doFunc"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput Do<TInput>(
            this TInput input,
            [NotNull] Action<TInput> doFunc)
        {
            doFunc.CheckNullWithException(nameof(doFunc));
            doFunc(input);

            return input;
        }

        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="doFunc"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput DoIf<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] Action<TInput> doFunc)
        {
            isExecute.CheckNullWithException(nameof(isExecute));
            doFunc.CheckNullWithException(nameof(doFunc));

            if (isExecute(input)) { doFunc(input); }

            return input;
        }

        /// <summary>
        /// 对<paramref name="input"/>执行一些操作
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，true为执行 </para>
        /// <para><paramref name="doFunc"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput DoIf<TInput>(
            this TInput input,
            [NotNull] bool isExecute,
            [NotNull] Action<TInput> doFunc)
        {
            return FpObjectDoExtensions.DoIf(input, t => isExecute, doFunc);
        }
    }
}