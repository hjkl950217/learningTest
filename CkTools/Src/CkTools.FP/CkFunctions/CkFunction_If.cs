using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action

        /*
        竖exp1\横exp2   Action     Action<T>                  Action<T2,T1>
        Action          1           1                           1
        Action<T>       1           1                           1(类型推断问题，只能留1个)
        Action<T2,T1>   1           1(类型推断问题，只能留1个)       1
        */

        #region 第1列

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Action If(
            [NotNull] Action exp2,
            [NotNull] Action exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return () =>
            {
                if(judgeExp())
                {
                    exp1();
                }
                else
                {
                    exp2();
                }
            };
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        public static Action<TInput> If<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return t =>
            {
                if(judgeExp())
                {
                    exp1();
                }
                else
                {
                    exp2(t);
                }
            };
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <returns></returns>
        public static Action<TInput2, TInput1> If<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) =>
            {
                if(judgeExp())
                {
                    exp1();
                }
                else
                {
                    exp2(t2, t1);
                }
            };
        }

        #endregion 第1列

        #region 第2列

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        public static Action<TInput> If<TInput>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return t =>
            {
                if(judgeExp())
                {
                    exp1(t);
                }
                else
                {
                    exp2();
                }
            };
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput"></typeparam>
        /// <returns></returns>
        public static Action<TInput> If<TInput>(
            [NotNull] Action<TInput> exp2,
            [NotNull] Action<TInput> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return t =>
            {
                if(judgeExp())
                {
                    exp1(t);
                }
                else
                {
                    exp2(t);
                }
            };
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <returns></returns>
        public static Action<TInput2, TInput1> If<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput1> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) =>
            {
                if(judgeExp())
                {
                    exp1(t1);
                }
                else
                {
                    exp2(t2, t1);
                }
            };
        }

        #endregion 第2列

        #region 第3列

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <returns></returns>
        public static Action<TInput2, TInput1> If<TInput2, TInput1>(
            [NotNull] Action exp2,
            [NotNull] Action<TInput2, TInput1> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) =>
            {
                if(judgeExp())
                {
                    exp1(t2, t1);
                }
                else
                {
                    exp2();
                }
            };
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <returns></returns>
        public static Action<TInput2, TInput1> If<TInput2, TInput1>(
            [NotNull] Action<TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) =>
            {
                if(judgeExp())
                {
                    exp1(t2, t1);
                }
                else
                {
                    exp2(t1);
                }
            };
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <returns></returns>
        public static Action<TInput2, TInput1> If<TInput2, TInput1>(
            [NotNull] Action<TInput2, TInput1> exp2,
            [NotNull] Action<TInput2, TInput1> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) =>
            {
                if(judgeExp())
                {
                    exp1(t2, t1);
                }
                else
                {
                    exp2(t2, t1);
                }
            };
        }

        #endregion 第3列

        #endregion Action

        #region Func

        /*
         竖exp1\横exp2    Func<TR>     Func<T,TR>                     Func<T2,T1,TR>
         Func<TR>           1               1                           1
         Func<T,TR>         1               1                           1(类型推断问题，只能留1个)
         Func<T2,T1,TR>     1               1(类型推断问题，只能留1个)       1
         */

        #region 第1列

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TResult> If<TResult>(
            [NotNull] Func<TResult> exp2,
            [NotNull] Func<TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return () => judgeExp() ? exp1() : exp2();
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput, TResult> If<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp2,
            [NotNull] Func<TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return t => judgeExp() ? exp1() : exp2(t);
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput2, TInput1, TResult> If<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Func<TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) => judgeExp() ? exp1() : exp2(t2, t1);
        }

        #endregion 第1列

        #region 第2列

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput, TResult> If<TInput, TResult>(
            [NotNull] Func<TResult> exp2,
            [NotNull] Func<TInput, TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return t => judgeExp() ? exp1(t) : exp2();
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput, TResult> If<TInput, TResult>(
            [NotNull] Func<TInput, TResult> exp2,
            [NotNull] Func<TInput, TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return t => judgeExp() ? exp1(t) : exp2(t);
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput2, TInput1, TResult> If<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Func<TInput1, TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) => judgeExp() ? exp1(t1) : exp2(t2, t1);
        }

        #endregion 第2列

        #region 第3列

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput2, TInput1, TResult> If<TInput2, TInput1, TResult>(
            [NotNull] Func<TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) => judgeExp() ? exp1(t2, t1) : exp2();
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput2, TInput1, TResult> If<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput1, TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) => judgeExp() ? exp1(t2, t1) : exp2(t1);
        }

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <returns></returns>
        public static Func<TInput2, TInput1, TResult> If<TInput2, TInput1, TResult>(
            [NotNull] Func<TInput2, TInput1, TResult> exp2,
            [NotNull] Func<TInput2, TInput1, TResult> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return (t2, t1) => judgeExp() ? exp1(t2, t1) : exp2(t2, t1);
        }

        #endregion 第3列

        #endregion Func
    }
}