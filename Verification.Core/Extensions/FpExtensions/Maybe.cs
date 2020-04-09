using System.Diagnostics.CodeAnalysis;

namespace System
{
    public class Maybe
    {
        public bool HasValue { get; protected set; } = false;

        public bool IsNothing() => this.HasValue;

        /// <summary>
        /// Pure<para></para>
        /// 接收一个<paramref name="value"/>转换为<see cref="Maybe{T}"/>
        /// </summary>
        /// <typeparam name="A"></typeparam>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Maybe<A> Pure<A>(A value) where A : notnull => value;
    }
}