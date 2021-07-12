//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;

//namespace CkTools.FP
//{
//    /// <summary>
//    /// 函数式功能
//    /// </summary>
//    public static partial class CkFunctions
//    {
//        #region Action - 0入参 0出参

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <param name="exp"></param>
//        /// <param name="exps"></param>
//        /// <returns></returns>
//        public static Action Do(
//            [NotNull] Action exp,
//            [NotNull] params Action[] exps)
//        {
//            exp.CheckNullWithException(nameof(exp));
//            exps.CheckNullWithException(nameof(exps));

//            exps.For(t => exp += t);
//            return exp;
//        }

//        #endregion Action - 0入参 0出参

//        #region Action - 1入参 0出参

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <param name="exp2"></param>
//        /// <param name="exp1"></param>
//        /// <returns></returns>
//        public static Action<TInput> Do<TInput>(
//            [NotNull] Action<TInput> exp2,
//            [NotNull] Action<TInput> exp1)
//        {
//            exp2.CheckNullWithException(nameof(exp2));
//            exp1.CheckNullWithException(nameof(exp1));
//            exp1 += exp2;
//            return exp1;
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <param name="exp"></param>
//        /// <param name="exps"></param>
//        /// <returns></returns>
//        public static Action<TInput> Do<TInput>(
//            [NotNull] Action<TInput> exp,
//            [NotNull] params Action<TInput>[] exps)
//        {
//            exp.CheckNullWithException(nameof(exp));
//            exps.CheckNullWithException(nameof(exps));
//            exps.For(t => exp += t);
//            return exp;
//        }

//        #endregion Action - 1入参 0出参

//        #region 1个参数

//        //#region Func

//        ///// <summary>
//        ///// 管道
//        ///// </summary>
//        ///// <typeparam name="TInput"></typeparam>
//        ///// <typeparam name="TResult"></typeparam>
//        ///// <param name="sourceFunc"></param>
//        ///// <param name="action"></param>
//        ///// <returns></returns>
//        //public static Func<TInput, TResult> Do<TInput, TResult>(
//        //    [NotNull] Func<TInput, TResult> sourceFunc,
//        //    [NotNull] Action<TResult> action)
//        //{
//        //    sourceFunc.CheckNullWithException(nameof(sourceFunc));
//        //    action.CheckNullWithException(nameof(action));

//        //    return t =>
//        //    {
//        //        TResult result = sourceFunc(t);
//        //        action(result);
//        //        return result;
//        //    };
//        //}

//        ///// <summary>
//        ///// 管道
//        ///// </summary>
//        ///// <typeparam name="TInput"></typeparam>
//        ///// <typeparam name="TResult"></typeparam>
//        ///// <param name="sourceFunc"></param>
//        ///// <param name="actions"></param>
//        ///// <returns></returns>
//        //public static Func<TInput, TResult> Do<TInput, TResult>(
//        //    [NotNull] Func<TInput, TResult> sourceFunc,
//        //    [NotNull] params Action<TResult>[] actions)
//        //{
//        //    sourceFunc.CheckNullWithException(nameof(sourceFunc));
//        //    actions.CheckNullWithException(nameof(actions));

//        //    return t =>
//        //    {
//        //        TResult result = sourceFunc(t);
//        //        actions.For(item => item(result));
//        //        return result;
//        //    };
//        //}

//        //#endregion Func

//        #endregion 1个参数
//    }
//}