using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 不可变数据结构.表示一个<see cref="Value"/>不可为null的数据结构
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class Maybe<T> : Maybe
        where T : notnull
    {
        private readonly T innerValue;

        public T Value => base.HasValue ? this.innerValue : throw new InvalidOperationException("value is null");

#pragma warning disable CS8618 // 不可为 null 的字段未初始化。请考虑声明为可以为 null。

        private Maybe()
        {
        }

        public Maybe([AllowNull] T value)
        {
            if (value is null) return;
            this.innerValue = value;
            base.HasValue = true;
        }

        public Maybe([NotNull] Maybe<T> value)
        {
            if (value?.HasValue != true) return;
            this.innerValue = value.Value;
            base.HasValue = true;
        }

#pragma warning restore CS8618 // 不可为 null 的字段未初始化。请考虑声明为可以为 null。

        public static implicit operator Maybe<T>(T value)
        {
            return new Maybe<T>(value);
        }

        public static implicit operator T(Maybe<T> value)
        {
            CkFunctions.CheckNullWithException(value);
            return value.Value;
        }

        public override string ToString()
        {
            return base.HasValue ? this.Value.ToString() : "Nothing";
        }

        public static Maybe<T> Nothing()
        {
            return new Maybe<T>();
        }
    }
}