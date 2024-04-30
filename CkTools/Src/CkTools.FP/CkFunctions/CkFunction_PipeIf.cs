//using System;
//using System.Diagnostics.CodeAnalysis;

//namespace CkTools.FP
//{
//    /// <summary>
//    /// 函数式功能
//    /// </summary>
//    public static partial class CkFunctions
//    {
//        #region Action - 1入参 0出参

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="exp"/>：将要执行的处理 </para>
//        /// <para><paramref name="judgeExp"/>：判断是否执行，返回true为执行 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <returns></returns>
//        public static Action<TInput> PipeIf<TInput>(
//            [NotNull] Action<TInput> exp,
//            [NotNull] Func<TInput, bool> judgeExp)
//        {
//            return CkFunctions.If<TInput>(t => { }, exp, judgeExp);
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="exp"/>：将要执行的处理 </para>
//        /// <para><paramref name="judgeExp"/>：判断是否执行，返回true为执行 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <returns></returns>
//        public static Action<TInput> PipeIf<TInput>(
//            [NotNull] Action<TInput> exp,
//            [NotNull] Func<bool> judgeExp)
//        {
//            judgeExp.CheckNullWithException(nameof(judgeExp));
//            return CkFunctions.PipeIf<TInput>(exp, t => judgeExp());
//        }

//        #endregion Action - 1入参 0出参

//        #region Fun - 1入参 1出参

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="exp"/>：将要执行的处理 </para>
//        /// <para><paramref name="judgeExp"/>：判断是否执行，返回true为执行 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <returns></returns>
//        public static Func<TInput, TInput> PipeIf<TInput>(
//            [NotNull] Func<TInput, TInput> exp,
//            [NotNull] Func<TInput, bool> judgeExp)
//        {
//            exp.CheckNullWithException(nameof(exp));
//            judgeExp.CheckNullWithException(nameof(judgeExp));
//            return CkFunctions.If<TInput, TInput>(t => t, exp, judgeExp);
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <Value>
//        /// <para><paramref name="exp"/>：将要执行的处理 </para>
//        /// <para><paramref name="judgeExp"/>：判断是否执行，返回true为执行 </para>
//        /// </Value>
//        /// <typeparam name="TInput">可传递任意类型</typeparam>
//        /// <returns></returns>
//        public static Func<TInput, TInput> PipeIf<TInput>(
//            [NotNull] Func<TInput, TInput> exp,
//            [NotNull] Func<bool> judgeExp)
//        {
//            return CkFunctions.PipeIf<TInput>(exp, t => judgeExp());
//        }

//        #endregion Fun - 1入参 1出参
//    }
//}