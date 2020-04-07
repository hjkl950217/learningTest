namespace System
{
    public static class Maybe_1Extensions
    {
        /// <summary>
        /// 映射<para></para>
        /// 接收一个<paramref name="func"/>将<paramref name="input"/>转换为<see cref="Maybe{T}"/><para></para>
        /// 示例1：Maybe{int} t1 = 7;int b=t1;<para></para>
        /// 示例2：<see cref="Maybe{int}"/> t2 = <see cref="Maybe{int}"/>.Nothing();
        /// </summary>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="B"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Maybe<B> Fmap<A, B>(this Maybe<A> input, Func<A, B> func)
            where A : notnull
            where B : notnull
        {
            //switch (input)
            //{
            //    case { HasValue: true } a when input.HasValue:
            //        return new Maybe<B>(func(a.Value));

            //    case null:
            //    default:
            //        return Maybe<B>.Nothing();
            //}

            return input switch
            {
                null => Maybe<B>.Nothing(),
                { HasValue: true } => new Maybe<B>(func(input.Value)),
                _ => Maybe<B>.Nothing()
            };
        }
    }
}