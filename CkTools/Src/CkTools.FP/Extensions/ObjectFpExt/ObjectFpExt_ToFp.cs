namespace System
{
    /// <summary>
    /// 从对象上面直接调用的FP方法
    /// </summary>
    /// <remarks>
    /// 定义将对象转换为FP的方法
    /// </remarks>
    public static class ObjectExt_ToFp
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