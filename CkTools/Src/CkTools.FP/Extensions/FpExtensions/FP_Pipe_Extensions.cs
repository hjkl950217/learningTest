using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 函数式扩展-管道
    /// </summary>
    public static class FP_Pipe_Extensions
    {
        // (a->void)->(b->void)->...  => (a->void) <para></para>
        // 示例:  (string->void)->(int->void)->...  => (string->void)

        #region Action扩展-0个入参

        #endregion Action扩展-0个入参

        #region Action扩展-1个入参

        public static Action<TInput> Pipe<TInput>(
            [NotNull] this Action<TInput> sourceExp,
            [NotNull] params Action<TInput>[] exps)
        {
            CkFunctions.CheckNullWithException(sourceExp);
            CkFunctions.CheckNullWithException(exps);

            return t =>
            {
                sourceExp(t);
                for (int i = 0; i < exps.Length; i++)
                {
                    exps[i](t);
                }
            };
        }

        #endregion Action扩展-1个入参

        #region Action扩展-2个入参

        #endregion Action扩展-2个入参

        #region Func-0个入参

        #endregion Func-0个入参

        #region Func-1个入参

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceExp"></param>
        /// <param name="exps"></param>
        /// <returns></returns>
        public static Func<TResult> Pipe<TResult>(
            [NotNull] this Func<TResult> sourceExp,
            [NotNull] params Action<TResult>[] exps)
        {
            return CkFunctions.Compose(exps, sourceExp);
        }

        #endregion Func-1个入参

        #region Func-2个入参

        /// <summary>
        /// 管道
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TCenter"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceExp"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TCenter, TResult>(
          [NotNull] this Func<TInput, TCenter> sourceExp,
          [NotNull] Func<TCenter, TResult> exp)
        {
            return CkFunctions.Pipe(exp, sourceExp);
        }

        #endregion Func-2个入参
    }
}