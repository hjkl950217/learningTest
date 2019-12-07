using System;
using System.Collections.Generic;

namespace 语法验证与学习
{
    public abstract class TwoValueComparer<T, TValue1, TValue2> : EqualityComparer<T>
        where T : class
    {
        private readonly Func<T, T, bool> equals;
        private readonly Func<T, int> getHashCode;

        private Func<T, TValue1> getValue1;
        private Func<T, TValue2> getValue2;

        /*
         * HashPipe                                 -->
         *      IngoneNullReference
         *      GetHashCode
         *
         * _Input   getValue1 getValue2
         *
         * EqualsPipe                              -->
         *      IngoneNullReference
         *      Equals
         *
         *
         * _Output   <TValue1,TValue2,bool>  menthod  (Func<T, TValue1> ,Func<T, TValue2>) ->  Funn<Func<T, TValue1>,Func<T, TValue2>,Func<TValue1,TValue2,bool>>
         *
         */

        private Func<Func<T, TValue1>, Func<T, TValue2>, Func<T, T, bool>> EqualsPipe(params Func<TValue1, TValue2, bool>[] funcs)
            => (getValueFunc1, getValueFunc2)
                 => (t1, t2) =>
                 {
                     foreach (var item in funcs)
                     {
                         bool checkResult = item(getValueFunc1(t1), getValueFunc2(t2));
                         if (checkResult) return true;
                     }
                     return false;
                 };

        private Func<Func<T, TValue1>, Func<T, TValue2>, Func<T, int>> HashPipe(params Func<TValue1, TValue2, int>[] funcs)
            => (getValueFunc1, getValueFunc2)
             => t1 =>
             {
                 Func<TValue1, TValue2, int> tempFunc = funcs[0];
                 for (int i = 1 ; i < funcs.Length ; i++)
                 {
                     tempFunc += funcs[i];
                 }

                 return tempFunc(getValueFunc1(t1), getValueFunc2(t1));
             };

        private bool CheckEquals(TValue1 value1, TValue2 value2)
        {
            return value1.Equals(value2);
        }

        private int CheckHashCode(TValue1 value1, TValue2 value2)
        {
            return value1.GetHashCode() ^ value2.GetHashCode();
        }

        private bool CheckNullReference(TValue1 value1, TValue2 value2)
        {
            if (value1 == null && value2 == null) return true;
            else return false;
        }

        private int CheckNullReferenceForInt(TValue1 value1, TValue2 value2)
        {
            return CheckNullReference(value1, value2) ? 1 : 0;
        }

        //private int NullReferenceToZero<TValue>(TValue value1)
        //{
        //    if (value1 == null && value2 == null) return 0;
        //    else if (value1 != null && value2 == null) return value1.GetHashCode();
        //    else if (value1 == null && value2 != null) return value2.GetHashCode();

        //    //if (value1 == null && value2 == null) return 0;
        //    //else return int.MinValue;
        //}

        //private Func<T, T, bool> IngoneNullReference(
        //   Func<T, T, bool> equals)
        //{
        //    return (x, y) =>
        //    {
        //        if (x == null && y == null)
        //            return true;
        //        else if (x == null || y == null)
        //            return false;
        //        else
        //            return equals(x, y);
        //    };
        //}

        //private Func<T, int> IngoneNullReference(Func<T, int> getValue)
        //{
        //    return t =>
        //    {
        //        return t == null
        //        ? 0
        //        : getValue(t);
        //    };
        //}

        protected TwoValueComparer(
            Func<T, TValue1> getValue1,
            Func<T, TValue2> getValue2)
        {
            this.equals = this.EqualsPipe(
                this.CheckNullReference,
                this.CheckEquals
                )(getValue1, getValue2);

            this.getHashCode = this.HashPipe(
                this.CheckNullReferenceForInt,
                this.CheckHashCode
                )(getValue1, getValue2);

            // this.equals = this.Combin(
            //    this.IngoneNullReference(getValue1),
            //    this.IngoneNullReference(getValue2)
            //);

            // this.getHashCode = this.Combin(
            //         this.IngoneNullReference(this.GetHashCode(getValue1)),
            //         this.IngoneNullReference(this.GetHashCode(getValue2))
            //     );

            //this.HashPipe(

            //    )(this.getValue1())
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

        #endregion Equals

        #region GetHashCode

        private Func<T, int> GetHashCode<TCode>(Func<T, TCode> getValue)
        {
            return t =>
            {
                return getValue(t).GetHashCode();
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

        #endregion GetHashCode

        #region 接口实现

        public override bool Equals(T x, T y)
        {
            return this.equals(x, y);
        }

        public override int GetHashCode(T obj)
        {
            return this.getHashCode(obj);
        }

        #endregion 接口实现
    }
}