using System.Diagnostics.CodeAnalysis;

namespace System
{
    public static class ObjectExt_Pipe
    {
        #region Pipe

        /// <summary>
        /// 管道
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
            [NotNull] Func<TInput, TOutput> func)
        {
            func.CheckNullWithException(nameof(func));

            return func(input);
        }

        #endregion Pipe

        //#region PipeIf

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <returns></returns>
        //public static TInput PipeIf<TInput>(
        //    this TInput input,
        //    [NotNull] Func<TInput, bool> isExecute,
        //    [NotNull] Func<TInput, TInput> func)
        //{
        //    return CkFunctions.PipeIf<TInput>(func, isExecute)(input);
        //}

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <returns></returns>
        //public static TInput PipeIf<TInput>(
        //    this TInput input,
        //    bool isExecute,
        //    Func<TInput, TInput> func)
        //{
        //    func.CheckNullWithException(nameof(func));
        //    return input.PipeIf(t => isExecute, func);
        //}

        //#endregion PipeIf

        //#region TryPipe

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// <para><paramref name="handler"/>：异常处理函数 </para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <typeparam name="TOutput">输出类型</typeparam>
        ///// <returns></returns>
        //public static TOutput TryPipe<TInput, TOutput>(
        //    this TInput input,
        //    [NotNull] Func<TInput, TOutput> func,
        //    Func<TInput, Exception, TOutput> handler)
        //{
        //    func.CheckNullWithException(nameof(func));
        //    handler.CheckNullWithException(nameof(handler));

        //    try
        //    {
        //        return func(input);
        //    }
        //    catch (Exception ex)
        //    {
        //        return handler(input, ex);
        //    }
        //}

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// <para><paramref name="defaultValue"/>：发生异常时返回的默认值 </para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <typeparam name="TOutput">输出类型</typeparam>
        ///// <returns></returns>
        //public static TOutput TryPipe<TInput, TOutput>(
        //    this TInput input,
        //    [NotNull] Func<TInput, TOutput> func,
        //    TOutput defaultValue)
        //{
        //    return FpObjectPipeExtensions.TryPipe(input, func, (input, ex) => defaultValue);
        //}

        //#endregion TryPipe

        //#region TryPipeIf

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// <para><paramref name="handler"/>：异常处理函数</para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <returns></returns>
        //public static TInput TryPipeIf<TInput>(
        //    this TInput input,
        //    [NotNull] Func<TInput, bool> isExecute,
        //    [NotNull] Func<TInput, TInput> func,
        //    [NotNull] Func<TInput, Exception, TInput> handler)
        //{
        //    isExecute.CheckNullWithException(nameof(isExecute));
        //    func.CheckNullWithException(nameof(func));
        //    handler.CheckNullWithException(nameof(handler));

        //    Func<TInput, TInput> func2 = input =>
        //    {
        //        if (isExecute(input)) return func(input);
        //        else return input;
        //    };

        //    return FpObjectPipeExtensions.TryPipe(input, func2, handler);
        //}

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="isExecute"/>：判断是否执行，true为执行 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// <para><paramref name="handler"/>：异常处理函数</para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <returns></returns>
        //public static TInput TryPipeIf<TInput>(
        //    this TInput input,
        //    bool isExecute,
        //    [NotNull] Func<TInput, TInput> func,
        //    [NotNull] Func<TInput, Exception, TInput> handler)
        //{
        //    func.CheckNullWithException(nameof(func));
        //    handler.CheckNullWithException(nameof(handler));

        //    Func<TInput, TInput> func2 = input =>
        //    {
        //        if (isExecute) return func(input);
        //        else return input;
        //    };

        //    return FpObjectPipeExtensions.TryPipe(input, func2, handler);
        //}

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// <para><paramref name="defaultValue"/>：发生异常时返回的默认值</para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <returns></returns>
        //public static TInput TryPipeIf<TInput>(
        //    this TInput input,
        //    [NotNull] Func<TInput, bool> isExecute,
        //    [NotNull] Func<TInput, TInput> func,
        //    TInput defaultValue)
        //{
        //    return FpObjectPipeExtensions.TryPipeIf(input, isExecute, func, (intput, ex) => defaultValue);
        //}

        ///// <summary>
        ///// 管道
        ///// </summary>
        ///// <Value>
        ///// <para><paramref name="input"/>：要处理的值 </para>
        ///// <para><paramref name="isExecute"/>：判断是否执行，true为执行 </para>
        ///// <para><paramref name="func"/>：将要执行的处理 </para>
        ///// <para><paramref name="defaultValue"/>：发生异常时返回的默认值</para>
        ///// </Value>
        ///// <typeparam name="TInput">可传递任意类型</typeparam>
        ///// <returns></returns>
        //public static TInput TryPipeIf<TInput>(
        //    this TInput input,
        //    bool isExecute,
        //    [NotNull] Func<TInput, TInput> func,
        //    TInput defaultValue)
        //{
        //    return FpObjectPipeExtensions.TryPipeIf(input, t => true, func, (intput, ex) => defaultValue);
        //}

        //#endregion TryPipeIf
    }
}