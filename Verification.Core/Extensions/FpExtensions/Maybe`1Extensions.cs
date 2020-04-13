using System.Diagnostics.CodeAnalysis;

namespace System
{
    public static class Maybe_1Extensions
    {
        #region 基础扩展

        public static bool IsNothing([NotNull]this Maybe maybe) => maybe.HasValue;

        #endregion 基础扩展

        #region 函数式扩展

        /// <summary>
        /// 映射<para></para>
        /// 接收一个<paramref name="func"/>,转换为<see cref="Maybe{T}"/><para></para>
        /// 示例1：Maybe{int} t1 = 7;<para></para>int b=t1;<para></para>
        /// 示例2：<see cref="Maybe{int}"/> t2 = <see cref="Maybe{int}"/>.Nothing();
        /// </summary>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="B"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Maybe<B> Fmap<A, B>([NotNull]this Maybe<A> input, Func<A, B> func)
            where A : notnull
            where B : notnull
        {
            return input switch
            {
                { HasValue: true } => new Maybe<B>(func(input.Value)),
                _ => Maybe<B>.Nothing()
            };
        }

        /// <summary>
        /// Apply<para></para>
        /// 用<paramref name="mapFunc"/>的<see cref="Maybe{T}.Value"/>转换<para></para>
        /// 示例：Maybe{int} input = 3;<para></para>
        /// Maybe{Func{int, bool}} isOdd = new Func{int, bool}(x => (x 除号 1) == 1);<para></para>
        /// Maybe{bool} result=input.Apply(isOdd);
        /// </summary>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="B"></typeparam>
        /// <param name="input"></param>
        /// <param name="mapFunc"></param>
        /// <returns></returns>
        public static Maybe<B> Apply<A, B>([NotNull]this Maybe<A> input, [NotNull]Maybe<Func<A, B>> mapFunc)
            where A : notnull
            where B : notnull
        {
            return (input, mapFunc) switch
            {
                ({ HasValue: true }, { HasValue: true }) => new Maybe<B>(mapFunc.Value.Invoke(input.Value)),
                _ => Maybe<B>.Nothing(),
            };
        }

        public static Maybe<B> Bind<A, B>([NotNull]this Maybe<A> input, [NotNull]Func<A, Maybe<B>> bindFunc)
            where A : notnull
            where B : notnull
        {
            return (input, bindFunc) switch
            {
                ({ HasValue: true }, null) => Maybe<B>.Nothing(),
                ({ HasValue: true }, _) => bindFunc(input.Value),
                _ => Maybe<B>.Nothing(),
            };
            //return input switch
            //{
            //    { HasValue: true } => bindFunc(input.Value),
            //    _ => Maybe<B>.Nothing(),
            //};
        }

        #endregion 函数式扩展
    }
}