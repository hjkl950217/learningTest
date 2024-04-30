using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 从对象上面直接调用的FP方法
    /// </summary>
    public static class ObjectExt_PipeIf
    {
        #region Action版本

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
        public static TInput PipeIf<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] params Action[] doFuncs)
        {
            CkFunctions.CheckNullWithException(isExecute, doFuncs);

            if(isExecute(input))
            {
                CkFunctions.ComposeReverse(doFuncs)();
            }

            return input;
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
        public static TInput PipeIf<TInput>(
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
        public static TInput PipeIf<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] params Action<TInput>[] doFuncs)
        {
            CkFunctions.CheckNullWithException(isExecute, doFuncs);

            if(isExecute(input))
            {
                CkFunctions.ComposeReverse(doFuncs)(input);
            }

            return input;
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
        public static TInput PipeIf<TInput>(
            this TInput input,
            [NotNull] bool isExecute,
            [NotNull] params Action<TInput>[] doFuncs)
        {
            return ObjectExt_PipeIf.PipeIf(input, t => isExecute, doFuncs);
        }

        #endregion Action版本

        #region Func版本

        /// <summary>
        /// 管道 <para></para>
        /// a->(a->bool)->(a->a) => a <para></para>
        /// 示例： string->(string->bool)->(string->string) => string
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput PipeIf<TInput>(
            this TInput input,
            [NotNull] Func<TInput, bool> isExecute,
            [NotNull] Func<TInput, TInput> func
            )
        {
            CkFunctions.CheckNullWithException(isExecute, func);

            if(isExecute(input))
            {
                return func(input);
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// 管道 <para></para>
        /// a->( ()->bool)->(a->a) => a <para></para>
        /// 示例： string->( ()->bool)->(string->string) => string
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput PipeIf<TInput>(
            this TInput input,
            [NotNull] Func<bool> isExecute,
            [NotNull] Func<TInput, TInput> func
            )
        {
            return input.PipeIf(t => isExecute(), func);
        }

        /// <summary>
        /// 管道 <para></para>
        /// a->(()->bool)->(b->c) => c <para></para>
        /// 示例： string->(string->bool)->(string->int) => int
        /// </summary>
        /// <Value>
        /// <para><paramref name="input"/>：要处理的值 </para>
        /// <para><paramref name="isExecute"/>：判断是否执行，返回true为执行 </para>
        /// <para><paramref name="func"/>：将要执行的处理 </para>
        /// </Value>
        /// <typeparam name="TInput">可传递任意类型</typeparam>
        /// <returns></returns>
        public static TInput PipeIf<TInput>(
            this TInput input,
            bool isExecute,
            Func<TInput, TInput> func)
        {
            return input.PipeIf(t => isExecute, func);
        }

        #endregion Func版本
    }
}