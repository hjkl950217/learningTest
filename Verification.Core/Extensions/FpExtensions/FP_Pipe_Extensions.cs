using System.Diagnostics.CodeAnalysis;

namespace System
{
    /// <summary>
    /// 函数式扩展-管道
    /// </summary>
    public static class FP_Pipe_Extensions
    {
        #region Action

        #region 1个入参，1个出参

        /// <summary>
        /// 管道 <para></para>
        /// 适合： (a->b)->(b->void) => (a->void) <para></para>
        /// 示例:  (string->int)->(int->void) => (string->void)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Action<TInput> Pipe<TInput, TResult>(
            [NotNull] this Func<TInput, TResult> sourceFunc,
            [NotNull] Action<TResult> action)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            action.CheckNull(nameof(action));

            return t => action(sourceFunc(t));
        }

        /// <summary>
        /// 管道 <para></para>
        /// 适合： (a->void)->(a->void)->...  => (a->void) <para></para>
        /// 示例:  (string->void)->(string->void)->...  => (string->void)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="actions"></param>
        /// <returns></returns>
        public static Action<TInput> Pipe<TInput>(
            [NotNull] this Action<TInput> sourceFunc,
            [NotNull] params Action<TInput>[] actions)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            actions.CheckNull(nameof(actions));

            return t => actions.For(item => item(t));
        }

        /// <summary>
        /// 管道 <para></para>
        /// 适合： (a->b)->(b->void)->...  => (a->void) <para></para>
        /// 示例:  (string->int)->(int->void)->...  => (string->void)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="actions"></param>
        /// <returns></returns>
        public static Action<TInput> Pipe<TInput, TResult>(
            [NotNull] this Func<TInput, TResult> sourceFunc,
            [NotNull] params Action<TResult>[] actions)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            actions.CheckNull(nameof(actions));

            return t =>
            {
                TResult tempResult = sourceFunc(t);
                actions.For(item => item(tempResult));
            };
        }

        #endregion 1个入参，1个出参

        #region 2个入参，一个出参

        /// <summary>
        /// 管道 <para></para>
        /// 适合： ((a->b)->c)->(c->void) => ((a->b)->void) <para></para>
        /// 示例:  (string->int)->(int->void) => (string->void)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Action<TInput1, TInput2> Pipe<TInput1, TInput2, TResult>(
            [NotNull] this Func<TInput1, TInput2, TResult> sourceFunc,
            [NotNull] Action<TResult> action)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            action.CheckNull(nameof(action));

            return (x, y) => action(sourceFunc(x, y));
        }

        #endregion 2个入参，一个出参

        #endregion Action

        #region Func

        /// <summary>
        /// 管道 <para></para>
        /// 适合:  (a->b)->(b->c) => (a->c) <para></para>
        /// 示例： (string->int)->(int->bool) => (string->bool)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TCenter"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TCenter, TResult>(
          [NotNull] this Func<TInput, TCenter> sourceFunc,
          [NotNull] Func<TCenter, TResult> func)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            func.CheckNull(nameof(func));

            return t => func(sourceFunc(t)); ;
        }

        #endregion Func
    }
}