namespace System
{
    public static class ObjectExt_Fp
    {
        /// <summary>
        /// 将<paramref name="obj"/>转换为委托,不会检查null值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Func<T?> ToFunc<T>(this T? obj)
        {
            return () => obj;
        }
    }
}