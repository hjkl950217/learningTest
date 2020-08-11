using System.Diagnostics.CodeAnalysis;
using FluentValidation.Validators;

namespace System
{
    /// <summary>
    /// Mayby基类，不包含Mayby本身的逻辑，仅包含快捷方法。Mayby具体逻辑参考<see cref="Maybe{T}"/>
    /// </summary>
    public class Maybe
    {
        protected Maybe()
        {
        }

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
        public static Maybe<A> Pure<A>(A value) where A : notnull => new Maybe<A>(value);
    }
}