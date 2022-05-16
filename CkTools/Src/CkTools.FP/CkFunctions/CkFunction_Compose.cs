using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能-组合
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        /*
         竖exp1\横exp2    Action     Action<T>   Action<T2,T1>
         Action            x*           1          1
         Action<T>          1           1          2
         Action<T2,T1>      1           2          1
         */

        #region 第1排

        public static Action<TInput> Compose<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t => { exp1(); exp2(t); };
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { exp1(); exp2(t2, t1); };
        }

        #endregion 第1排

        #region 第2排

        public static Action<TInput> Compose<TInput>(
        [NotNull] Action exp2,
        [NotNull] Action<TInput> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t => { exp1(t); exp2(); };
        }

        public static Action<TInput> Compose<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action<TInput> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t => { exp1(t); exp2(t); };
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { exp1(t2); exp2(t2, t1); };
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { exp1(t1); exp2(t2, t1); };
        }

        #endregion 第2排

        #region 第3排

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
         [NotNull] Action exp2,
         [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { exp1(t2, t1); exp2(); };
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
               [NotNull] Action<TInput2> exp2,
               [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { exp1(t2, t1); exp2(t2); };
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
            [NotNull] Action<TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { exp1(t2, t1); exp2(t1); };
        }

        public static Action<TInput2, TInput1> Compose<TInput2, TInput1>(
             [NotNull] Action<TInput2, TInput1> exp2,
             [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { exp1(t2, t1); exp2(t2, t1); };
        }

        #endregion 第3排

        #region 其它

        public static Action Compose(
            [NotNull] params Action[] actions)
        {
            CheckNullWithException(actions);
            return () =>
            {
                //倒序执行
                for (int i = actions.Length - 1 ; i > -1 ; i--)
                {
                    actions[i]();
                }
            };
        }

        public static Action<TInput> Compose<TInput>(
            [NotNull] params Action<TInput>[] actions)
        {
            CheckNullWithException(actions);
            return t =>
            {
                //倒序执行
                for (int i = actions.Length - 1 ; i > -1 ; i--)
                {
                    Action<TInput>? item = actions[i];
                    item(t);
                }
            };
        }

        #endregion 其它

        #endregion Action

        #region Func

        /*
         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
         Func<TR>           x               1              x
         Func<T,TR>         x               1              1
         Func<T2,T1,TR>     x               x              x
         */

        public static Func<TResultEnd> Compose<TResult1, TResultEnd>(
            [NotNull] Func<TResult1, TResultEnd> exp2,
            [NotNull] Func<TResult1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return () => exp2(exp1());
        }

        public static Func<TInput, TResultEnd> Compose<TInput, TResult1, TResultEnd>(
            [NotNull] Func<TResult1, TResultEnd> exp2,
            [NotNull] Func<TInput, TResult1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t => exp2(exp1(t));
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Func<TResult, TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) => { return exp2(exp1(t2, t1)); };
        }

        #region 其它

        public static Func<TInput1, TResultEnd> Compose<TInput1, TResult1, TResult2, TResultEnd>(
            [NotNull] Func<TResult2, TResultEnd> exp3,
            [NotNull] Func<TResult1, TResult2> exp2,
            [NotNull] Func<TInput1, TResult1> exp1)
        {
            CheckNullWithException(exp3, exp2, exp1);
            return t => exp3(exp2(exp1(t)));
        }

        public static Func<TInput1, TResultEnd> Compose<TInput1, TResult1, TResult2, TResult3, TResultEnd>(
            [NotNull] Func<TResult3, TResultEnd> exp4,
            [NotNull] Func<TResult2, TResult3> exp3,
            [NotNull] Func<TResult1, TResult2> exp2,
            [NotNull] Func<TInput1, TResult1> exp1)
        {
            CheckNullWithException(exp4, exp3, exp2, exp1);
            return t => exp4(exp3(exp2(exp1(t))));
        }

        public static Func<TInput1, TResultEnd> Compose<TInput1, TResult1, TResult2, TResult3, TResult4, TResultEnd>(
            [NotNull] Func<TResult4, TResultEnd> exp5,
            [NotNull] Func<TResult3, TResult4> exp4,
            [NotNull] Func<TResult2, TResult3> exp3,
            [NotNull] Func<TResult1, TResult2> exp2,
            [NotNull] Func<TInput1, TResult1> exp1)
        {
            CkFunctions.CheckNullWithException(exp5, exp4, exp3, exp2, exp1);
            return t => exp5(exp4(exp3(exp2(exp1(t)))));
        }

        public static Func<TResult> Compose<TResult>(
            [NotNull] Action<TResult>[] exps2,
            [NotNull] Func<TResult> exp1)
        {
            CkFunctions.CheckNullWithException(exp1);
            CkFunctions.CheckNullWithException(exps2);

            TResult result1 = exp1();

            return () =>
            {
                for (int i = 0 ; i < exps2.Length ; i++)
                {
                    Action<TResult>? item = exps2[i];
                    item(result1);
                }

                return result1;
            };
        }

        #endregion 其它

        #endregion Func

        #region exp1 Func  -  exp2 Action

        /* 竖
         竖exp1\横exp2    Action     Action<T>   Action<T2,T1>
         Func<TR>           1           1           x
         Func<T,TR>         1           1           x
         Func<T2,T1,TR>     1           1           x

         */

        #region 第1排

        public static Func<TResult> Compose<TResult>(
            [NotNull] Action exp2,
            [NotNull] Func<TResult> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return () =>
            {
                TResult tempResult = exp1();
                exp2();
                return tempResult;
            };
        }

        public static Func<TResult> Compose<TResult>(
            [NotNull] Action<TResult> exp2,
            [NotNull] Func<TResult> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return () =>
            {
                TResult tempResult = exp1();
                exp2(tempResult);
                return tempResult;
            };
        }

        #endregion 第1排

        #region 第2排

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            [NotNull] Action exp2,
            [NotNull] Func<TInput, TResult> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t =>
            {
                TResult tempResult = exp1(t);
                exp2();
                return tempResult;
            };
        }

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            [NotNull] Action<TResult> exp2,
            [NotNull] Func<TInput, TResult> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t =>
            {
                TResult tempResult = exp1(t);
                exp2(tempResult);
                return tempResult;
            };
        }

        #endregion 第2排

        #region 第3排

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Action exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) =>
            {
                TResult tempResult = exp1(t2, t1);
                exp2();
                return tempResult;
            };
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Action<TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) =>
            {
                TResult tempResult = exp1(t2, t1);
                exp2(tempResult);
                return tempResult;
            };
        }

        #endregion 第3排

        #endregion exp1 Func  -  exp2 Action

        #region exp1 Action  -  exp2 Func

        /*
         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
         Action             1           1           1
         Action<T>          1           1           1
         Action<T2,T1>      1           x           1

         */

        #region 第1排

        public static Func<TResult> Compose<TResult>(
            [NotNull] Func<TResult> exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return () =>
            {
                exp1();
                TResult tempResult = exp2();

                return tempResult;
            };
        }

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t =>
            {
                exp1();
                TResult tempResult = exp2(t);
                return tempResult;
            };
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) =>
            {
                exp1();
                TResult tempResult = exp2(t2, t1);
                return tempResult;
            };
        }

        #endregion 第1排

        #region 第2排

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            [NotNull] Func<TResult> exp2,
            [NotNull] Action<TInput> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t =>
            {
                exp1(t);
                TResult tempResult = exp2();

                return tempResult;
            };
        }

        public static Func<TInput, TResult> Compose<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp2,
            [NotNull] Action<TInput> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return t =>
            {
                exp1(t);
                TResult tempResult = exp2(t);
                return tempResult;
            };
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action<TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) =>
            {
                exp1(t1);
                TResult tempResult = exp2(t2, t1);
                return tempResult;
            };
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action<TInput2> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) =>
            {
                exp1(t2);
                TResult tempResult = exp2(t2, t1);
                return tempResult;
            };
        }

        #endregion 第2排

        #region 第3排

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Func<TResult> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) =>
            {
                exp1(t2, t1);
                TResult tempResult = exp2();
                return tempResult;
            };
        }

        public static Func<TInput2, TInput1, TResult> Compose<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Action<TInput2, TInput1> exp1)
        {
            CheckNullWithException(exp2, exp1);
            return (t2, t1) =>
            {
                exp1(t2, t1);
                TResult tempResult = exp2(t2, t1);
                return tempResult;
            };
        }

        #endregion 第3排

        #endregion exp1 Action  -  exp2 Func
    }
}