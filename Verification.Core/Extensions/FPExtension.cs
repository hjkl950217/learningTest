using System.Diagnostics.CodeAnalysis;

namespace System
{
    public static class FPExtension
    {
        #region 管道

        /// <summary>
        /// 管道 <para></para>
        /// 适合:  a->b->c  得到 a->c 函数
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TCenter"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Pipe<TInput, TCenter, TResult>(
          this Func<TInput, TCenter> sourceFunc,
          [NotNull] Func<TCenter, TResult> func)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            func.CheckNull(nameof(func));

            return t => func(sourceFunc(t)); ;
        }

        /// <summary>
        /// 管道 <para></para>
        /// 适合:  a->b->void  得到 a->void 函数
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Action<TInput> Pipe<TInput, TResult>(
            this Func<TInput, TResult> sourceFunc,
            [NotNull] Action<TResult> action)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            action.CheckNull(nameof(action));

            return t => action(sourceFunc(t));
        }

        /// <summary>
        /// 管道 <para></para>
        /// 适合:  a->...->void  得到 a->void 函数
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="actions"></param>
        /// <returns></returns>
        public static Action<TInput> Pipe<TInput>(
            this Action<TInput> sourceFunc,
            [NotNull] params Action<TInput>[] actions)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            actions.CheckNull(nameof(actions));

            return t => actions.For(item => item(t));
        }

        /// <summary>
        /// 管道 <para></para>
        /// 适合:  (a->c)->...->void  得到 a->void 函数
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="actions"></param>
        /// <returns></returns>
        public static Action<TInput> Pipe<TInput, TResult>(
            this Func<TInput, TResult> sourceFunc,
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

        #endregion 管道
    }
}