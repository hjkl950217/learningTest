//using System.Diagnostics.CodeAnalysis;
//using CkTools.FP;

//namespace System
//{
//    public static class FP_Do_Extensions
//    {
//        #region 1个参数

//        #region Action

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <param name="sourceExp"></param>
//        /// <param name="exp"></param>
//        /// <returns></returns>
//        public static Action<TInput> Do<TInput>(
//            [NotNull] this Action<TInput> sourceExp,
//            [NotNull] Action<TInput> exp)
//        {
//            CkFunctions.CheckNullWithException(sourceExp, exp);

//            sourceExp += exp;
//            return sourceExp;
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <param name="sourceExp"></param>
//        /// <param name="exps"></param>
//        /// <returns></returns>
//        public static Action<TInput> Do<TInput>(
//            [NotNull] this Action<TInput> sourceExp,
//            [NotNull] params Action<TInput>[] exps)
//        {
//            CkFunctions.CheckNullWithException(sourceExp, exps);

//            exps.For(t => sourceExp += t);
//            return sourceExp;
//        }

//        #endregion Action

//        #region Func

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <typeparam name="TResult"></typeparam>
//        /// <param name="sourceExp"></param>
//        /// <param name="exp"></param>
//        /// <returns></returns>
//        public static Func<TInput, TResult> Do<TInput, TResult>(
//            [NotNull] this Func<TInput, TResult> sourceExp,
//            [NotNull] Action<TResult> exp)
//        {
//            CkFunctions.CheckNullWithException(sourceExp, exp);

//            return t =>
//            {
//                TResult result = sourceExp(t);
//                exp(result);
//                return result;
//            };
//        }

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <typeparam name="TResult"></typeparam>
//        /// <param name="sourceExp"></param>
//        /// <param name="exps"></param>
//        /// <returns></returns>
//        public static Func<TInput, TResult> Do<TInput, TResult>(
//            [NotNull] this Func<TInput, TResult> sourceExp,
//            [NotNull] params Action<TResult>[] exps)
//        {
//            CkFunctions.CheckNullWithException(sourceExp, exps);

//            return t =>
//            {
//                TResult result = sourceExp(t);
//                exps.For(item => item(result));
//                return result;
//            };
//        }

//        #endregion Func

//        #endregion 1个参数
//    }
//}