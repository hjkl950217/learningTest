namespace System
{
    /// <summary>
    /// 函数式扩展-柯里化
    /// </summary>
    public static class Fp_Currying_Extensions
    {
        public static Func<T1, Func<T2, TResult>> Currying<T1, T2, TResult>(
            this Func<T1, T2, TResult> func)
            => x => y => func(x, y);

        public static Func<T1, Func<T2, Func<T3, TResult>>> Currying<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> func)
            => x => y => z => func(x, y, z);

        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Currying<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> func)
            => x => y => z => g => func(x, y, z, g);

        // 后续还有东西没理解：https://zhuanlan.zhihu.com/p/94591842
    }
}