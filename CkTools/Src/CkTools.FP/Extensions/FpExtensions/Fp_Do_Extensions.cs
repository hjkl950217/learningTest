//using System.Diagnostics.CodeAnalysis;
//using CkTools.FP;

//namespace System
//{
//    public static class FP_Do_Extensions
//    {
//        #region Action

//        /*
//         竖exp1\横exp2    Action     Action<T>   Action<T2,T1>
//         Action             1           1          1
//         Action<T>          1           1          3
//         Action<T2,T1>      1           x          1
//         */

//        #region 第1列

//        public static Action Do(
//            this Action exp2,
//            [NotNull] Action exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Action<TInput> Do<TInput>(
//            this Action<TInput> exp2,
//            [NotNull] Action exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
//            this Action<TInput2, TInput1> exp2,
//            [NotNull] Action exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        #endregion 第1列

//        #region 第2列

//        public static Action<TInput> Do<TInput>(
//            this Action exp2,
//            [NotNull] Action<TInput> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Action<TInput> Do<TInput>(
//            this Action<TInput> exp2,
//            [NotNull] Action<TInput> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
//            this Action<TInput2, TInput1> exp2,
//            [NotNull] Action<TInput1> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
//            this Action<TInput2, TInput1> exp2,
//            [NotNull] Action<TInput2> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Action<TInput, TInput> Do<TInput>(
//           this Action<TInput, TInput> exp2,
//           [NotNull] Action<TInput> exp1)
//        {
//            return CkFunctions.Compose<TInput>(exp2, exp1);
//        }

//        #endregion 第2列

//        #region 第3列

//        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
//            this Action exp2,
//            [NotNull] Action<TInput2, TInput1> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Action<TInput2, TInput1> Do<TInput2, TInput1>(
//            this Action<TInput2, TInput1> exp2,
//            [NotNull] Action<TInput2, TInput1> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        #endregion 第3列

//        #endregion Action

//        #region Func

//        /*
//         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
//         Func<TR>           x               x              x
//         Func<T,TR>         x               x              x
//         Func<T2,T1,TR>     x               x              x
//         */

//        #endregion Func

//        #region exp1 Func  -  exp2 Action

//        /*
//         竖exp1\横exp2    Action     Action<TR>   Action<T2,T1>
//         Func<TR>           1           1           x
//         Func<T,TR>         1           1           x
//         Func<T2,T1,TR>     1           1           x

//         */

//        #region 第1列

//        public static Func<TResult> Do<TResult>(
//            this Action exp2,
//            [NotNull] Func<TResult> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Func<TResult> Do<TResult>(
//            this Action<TResult> exp2,
//            [NotNull] Func<TResult> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        #endregion 第1列

//        #region 第2列

//        public static Func<TInput, TResult> Do<TInput, TResult>(
//            this Action exp2,
//            [NotNull] Func<TInput, TResult> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Func<TInput, TResult> Do<TInput, TResult>(
//            this Action<TResult> exp2,
//            [NotNull] Func<TInput, TResult> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        #endregion 第2列

//        #region 第3列

//        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
//            this Action exp2,
//            [NotNull] Func<TInput2, TInput1, TResult> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
//            this Action<TResult> exp2,
//            [NotNull] Func<TInput2, TInput1, TResult> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        #endregion 第3列

//        #endregion exp1 Func  -  exp2 Action

//        #region exp1 Action  -  exp2 Func

//        /*
//         竖exp1\横exp2    Func<TR>     Func<T,TR>   Func<T2,T1,TR>
//         Action             1           1           1
//         Action<T>          x           1           x
//         Action<T2,T1>      x           x           1

//         */

//        #region 第1列

//        public static Func<TResult> Do<TResult>(
//            this Func<TResult> exp2,
//            [NotNull] Action exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Func<TInput, TResult> Do<TInput, TResult>(
//            this Func<TInput, TResult> exp2,
//            [NotNull] Action exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
//            this Func<TInput2, TInput1, TResult> exp2,
//            [NotNull] Action exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        #endregion 第1列

//        #region 第2列

//        public static Func<TInput, TResult> Do<TInput, TResult>(
//             this Func<TInput, TResult> exp2,
//             [NotNull] Action<TInput> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        //public static Func<TInput, TResult> Do<TInput, TResult>(
//        //     this Func<TInput, TResult> exp2,
//        //     [NotNull] Action<TResult> exp1)
//        //{
//        //    return CkFunctions.Compose(exp1, exp2);
//        //}

//        #endregion 第2列

//        #region 第3列

//        public static Func<TInput2, TInput1, TResult> Do<TInput2, TInput1, TResult>(
//            this Func<TInput2, TInput1, TResult> exp2,
//            [NotNull] Action<TInput2, TInput1> exp1)
//        {
//            return CkFunctions.Compose(exp2, exp1);
//        }

//        #endregion 第3列

//        #endregion exp1 Action  -  exp2 Func
//    }
//}