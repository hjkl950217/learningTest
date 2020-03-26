using System.Diagnostics.CodeAnalysis;

namespace System
{
    public static class Fp_Do_Extensions
    {
        /// <summary>
        /// 管道 <para></para>
        /// 适合:  (a->b)->(b->void)->... => (a->b) <para></para>
        /// 示例： (string->int)->(int->void)->... => (string->int)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Func<TInput, TResult> Do<TInput, TResult>(
            [NotNull] this Func<TInput, TResult> sourceFunc,
            [NotNull] params Action<TResult>[] actions)
        {
            sourceFunc.CheckNull(nameof(sourceFunc));
            actions.CheckNull(nameof(actions));

            return t =>
            {
                TResult result = sourceFunc(t);
                actions.For(item => item(result));
                return result;
            };
        }

        /// <summary>
        /// 管道 <para></para>
        /// 适合： (a->void)->(a->void)->...  => (a->void) <para></para>
        /// 示例:  (string->void)->(string->void)->...  => (string->void)
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="sourceFunc"></param>
        /// <param name="actions"></param>
        /// <remarks>
        /// 这里和<see cref="FP_Pipe_Extensions.Pipe{TInput}(Action{TInput}, Action{TInput}[])"/>是一样的，这里修改名字是方便调用者
        /// </remarks>
        /// <returns></returns>
        public static Action<TInput> Do<TInput>(
            [NotNull] this Action<TInput> sourceFunc,
            [NotNull] params Action<TInput>[] actions)
        {
            return FP_Pipe_Extensions.Pipe(sourceFunc, actions);
        }
    }
}