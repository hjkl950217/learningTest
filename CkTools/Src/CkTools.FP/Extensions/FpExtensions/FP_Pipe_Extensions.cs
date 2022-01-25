//using System.Diagnostics.CodeAnalysis;
//using CkTools.FP;

//namespace System
//{
//    /// <summary>
//    /// 函数式扩展-管道
//    /// </summary>
//    public static class FP_Pipe_Extensions
//    {
//        #region 返回Action

//        #region 0个入参

//        /// <summary>
//        /// 管道 <para></para>
//        /// (a->void)->(b->void)->...  => (a->void) <para></para>
//        /// 示例:  (string->void)->(int->void)->...  => (string->void)
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <param name="sourceExp"></param>
//        /// <param name="exps"></param>
//        /// <returns></returns>
//        public static Action<TInput> Pipe<TInput>(
//            [NotNull] this Func<TInput> sourceExp,
//            [NotNull] params Action<TInput>[] exps)
//        {
//            return CkFunctions.Pipe(sourceExp, exps);
//        }

//        #endregion 0个入参

//        #region 1个入参

//        ///// <summary>
//        ///// 管道 <para></para>
//        ///// (a->b)->(b->void)->...  => (a->void) <para></para>
//        ///// 示例:  (string->int)->(int->void)->...  => (string->void)
//        ///// </summary>
//        ///// <typeparam name="TInput"></typeparam>
//        ///// <typeparam name="TResult"></typeparam>
//        ///// <param name="sourceExp"></param>
//        ///// <param name="exps"></param>
//        ///// <returns></returns>
//        //public static Action<TInput> Pipe<TInput, TResult>(
//        //    [NotNull] this Func<TInput, TResult> sourceExp,
//        //    [NotNull] params Action<TResult>[] exps)
//        //{
//        //    return CkFunctions.Pipe(sourceExp, exps);
//        //}

//        #endregion 1个入参

//        #endregion 返回Action

//        #region 0个入参

//        /// <summary>
//        /// 管道 <para></para>
//        /// (a->void)->(b->void)->...  => (a->void) <para></para>
//        /// 示例:  (string->void)->(int->void)->...  => (string->void)
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <param name="sourceExp"></param>
//        /// <param name="exps"></param>
//        /// <returns></returns>
//        public static Action<TInput> Pipe<TInput>(
//            [NotNull] this Action<TInput> sourceExp,
//            [NotNull] params Action<TInput>[] exps)
//        {
//            return CkFunctions.Pipe<TInput>(sourceExp, exps);
//        }

//        #endregion 0个入参

//        #region 1个入参

//        ///// <summary>
//        ///// 管道
//        ///// </summary>
//        ///// <typeparam name="TInput"></typeparam>
//        ///// <param name="sourceExp"></param>
//        ///// <param name="exps"></param>
//        ///// <returns></returns>
//        //public static Action<TInput> Pipe<TInput>(
//        //    [NotNull] this Action<TInput> sourceExp,
//        //    [NotNull] params Action<TInput>[] exps)
//        //{
//        //    return CkFunctions.Pipe(sourceExp, exps);
//        //}

//        #endregion 1个入参

//        #region 返回Func

//        /// <summary>
//        /// 管道
//        /// </summary>
//        /// <typeparam name="TInput"></typeparam>
//        /// <typeparam name="TCenter"></typeparam>
//        /// <typeparam name="TResult"></typeparam>
//        /// <param name="sourceExp"></param>
//        /// <param name="exp"></param>
//        /// <returns></returns>
//        public static Func<TInput, TResult> Pipe<TInput, TCenter, TResult>(
//          [NotNull] this Func<TInput, TCenter> sourceExp,
//          [NotNull] Func<TCenter, TResult> exp)
//        {
//            return CkFunctions.Pipe(sourceExp, exp);
//        }

//        #endregion 返回Func
//    }
//}