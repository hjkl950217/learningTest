using System;
using System.Collections.Generic;

namespace 语法验证与学习
{
    public abstract class TwoValueComparer<T, TValue1, TValue2> : EqualityComparer<T>
    {
        private readonly Func<T, T, bool> equals;
        private readonly Func<T, int> getHashCode;

        protected TwoValueComparer(
            Func<T, TValue1> getValue1,
            Func<T, TValue2> getValue2)
        {
            this.equals = this.IngoneNullReference(this.Combin(getValue1, getValue2));

            this.getHashCode = this.IngoneNullReference(this.Combin
                (
                    this.GetHashCode(this.ShowValue(getValue1)),
                    this.GetHashCode(this.ShowValue(getValue2)))
                );
        }

        #region Equals

        private Func<T, T, bool> Combin<TCode>(
            Func<T, TCode> getValue1,
            Func<T, TValue2> getValue2)
        {
            return (x, y) =>
            {
                return getValue1(x).Equals(getValue1(y))
                        && getValue2(x).Equals(getValue2(y));
            };
        }

        private Func<T, T, bool> IngoneNullReference(
           Func<T, T, bool> equals)
        {
            return (x, y) =>
            {
                if (x == null && y == null)
                    return true;
                else if (x == null || y == null)
                    return false;
                else
                    return equals(x, y);
            };
        }

        #endregion Equals

        #region GetHashCode

        private Func<T, TCode> ShowValue<TCode>(Func<T, TCode> getValue)
        {
            return t =>
            {
                System.Console.WriteLine($"[{getValue(t)}]");
                return getValue(t);
            };
        }

        private Func<T, int> GetHashCode<TCode>(Func<T, TCode> getValue)
        {
            return t =>
            {
                return getValue(t).GetHashCode();
            };
        }

        private Func<T, int> Show(
           Func<T, int> getFirstHashCode,
           Func<T, int> getSecondHashCode)
        {
            return t =>
            {
                return getFirstHashCode(t) ^ getSecondHashCode(t);
            };
        }

        private Func<T, int> Combin(
           Func<T, int> getFirstHashCode,
           Func<T, int> getSecondHashCode)
        {
            return t =>
            {
                return getFirstHashCode(t) ^ getSecondHashCode(t);
            };
        }

        private Func<T, int> IngoneNullReference(Func<T, int> getValue)
        {
            return t =>
            {
                return t == null
                ? 0
                : getValue(t);
            };
        }

        #endregion GetHashCode

        public override bool Equals(T x, T y)
        {
            return this.equals(x, y);
        }

        public override int GetHashCode(T obj)
        {
            return this.getHashCode(obj);
        }
    }
}