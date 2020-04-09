using System.Diagnostics.CodeAnalysis;

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

        public T Value => this.HasValue ? this.innerValue : throw new InvalidOperationException();

        private Maybe()
        {
        }

        public Maybe(T value)
        {
            if (value is null) return;
            this.innerValue = value;
            base.HasValue = true;
        }

        public Maybe(Maybe<T> value)
        {
            if (!value.HasValue) return;
            this.innerValue = value.Value;
            base.HasValue = true;
        }

        public static implicit operator Maybe<T>(T value)
        {
            return new Maybe<T>(value);
        }

        public static implicit operator T(Maybe<T> value)
        {
            value.CheckNull(nameof(value));
            return value.Value;
        }

        public override string ToString()
        {
            return this.HasValue ? this.Value.ToString() : "Nothing";
        }

        public static Maybe<T> Nothing()
        {
            return new Maybe<T>();
        }
    }
}