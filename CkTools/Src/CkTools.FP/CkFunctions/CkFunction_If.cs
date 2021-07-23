using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        #region Action - 0入参 0出参

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
        public static Action If<TInput>(
            [NotNull] Action exp2,
            [NotNull] Action exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return () =>
            {
                if (judgeExp())
                    exp1();
                else
                    exp2();
            };
        }

        #endregion Action - 0入参 0出参

        #region Action - 1入参 0出参

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
            [NotNull] Func<TInput, bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return t =>
            {
                if (judgeExp(t))
                    exp1(t);
                else
                    exp2(t);
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
            [NotNull] Func<TInput, bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return CkFunctions.If<TInput>(exp2, t => exp1(), judgeExp);
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

            return CkFunctions.If<TInput>(exp2, exp1, t => judgeExp());
        }

        #endregion Action - 1入参 0出参

        #region Func - 0入参 1出参

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TOutput"></typeparam>
        /// <returns></returns>
        public static Func<TOutput> If<TOutput>(
            [NotNull] Func<TOutput> exp2,
            [NotNull] Func<TOutput> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return () => judgeExp()
            ? exp1()
            : exp2();
        }

        #endregion Func - 0入参 1出参

        #region Fun - 1入参 1出参

        /// <summary>
        /// If
        /// </summary>
        /// <Value>
        /// <para><paramref name="exp2"/>：为false时执行的函数 </para>
        /// <para><paramref name="exp1"/> 为true时执行的函数 </para>
        /// <para><paramref name="judgeExp"/>：指示如何判断的函数 </para>
        /// </Value>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <returns></returns>
        public static Func<TInput, TOutput> If<TInput, TOutput>(
            [NotNull] Func<TInput, TOutput> exp2,
            [NotNull] Func<TInput, TOutput> exp1,
            [NotNull] Func<TInput, bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);

            return input => judgeExp(input)
            ? exp1(input)
            : exp2(input);
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
        public static Func<TInput, TInput> If<TInput>(
            [NotNull] Func<TInput, TInput> exp2,
            [NotNull] Func<TInput, TInput> exp1,
            [NotNull] Func<TInput, bool> judgeExp)
        {
            return CkFunctions.If<TInput, TInput>(exp2, exp1, judgeExp);
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
        /// <typeparam name="TOutput"></typeparam>
        /// <returns></returns>
        public static Func<TInput, TOutput> If<TInput, TOutput>(
            [NotNull] Func<TInput, TOutput> exp2,
            [NotNull] Func<TInput, TOutput> exp1,
            [NotNull] Func<bool> judgeExp)
        {
            CkFunctions.CheckNullWithException(exp2, exp1, judgeExp);
            return CkFunctions.If<TInput, TOutput>(exp2, exp1, t => judgeExp());
        }

        #endregion Fun - 1入参 1出参
    }
}