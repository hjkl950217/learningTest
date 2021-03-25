namespace CkTools.FP
{
    /// <summary>
    /// 函数式功能
    /// </summary>
    public static partial class CkFunctions
    {
        ///// <summary>
        ///// If-柯里化版本<para></para>
        ///// 返回函数:<para></para>
        ///// 第一函数:为false时执行的函数<para></para>
        ///// 第二函数:为true时执行的函数<para></para>
        ///// 第三函数:指示如何判断的函数
        ///// </summary>
        ///// <typeparam name="TInput"></typeparam>
        ///// <returns></returns>
        //public static Func<Func<TInput, TInput>, Func<Func<TInput, TInput>, Func<Func<TInput, bool>, Func<Func<TInput, TInput>>>>> IfCurrying<TInput>()
        //{
        //    Func<Func<TInput, TInput>, Func<TInput, TInput>, Func<TInput, bool>, Func<TInput, TInput>> ifMethod = CkFunctions.If<TInput, TInput>;

        //    return FP_Currying_Extensions.Currying(ifMethod);
        //}
    }
}