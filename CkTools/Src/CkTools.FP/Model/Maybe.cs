using System.Diagnostics.CodeAnalysis;

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

        private bool hasValue;

        /// <summary>
        /// 是否有值,对象为null或有值是返回true
        /// </summary>
        public bool HasValue
        {
            get { return this?.hasValue ?? false; }
            protected set { this.hasValue = value; }
        }

        public bool IsNothing() => this.HasValue;

        /// <summary>
        /// 获取一个空值<see cref="Maybe"/>
        /// </summary>
        /// <returns></returns>
        public static Maybe Nothing() => new Maybe();

        /// <summary>
        /// Pure<para></para>
        /// 接收一个<paramref name="value"/>转换为<see cref="Maybe{T}"/>
        /// </summary>
        /// <typeparam name="A"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Maybe<A> Pure<A>([AllowNull] A value) where A : notnull => new Maybe<A>(value);
    }
}