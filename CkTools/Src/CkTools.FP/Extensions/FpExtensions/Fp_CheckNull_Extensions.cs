using System.Collections;
using CkTools.FP;

namespace System
{
    /// <summary>
    /// 函数式扩展-检查空
    /// </summary>
    public static class Fp_CheckNull_Extensions
    {
        public static bool IsNull<T>(this T obj)
            where T : class?
        {
            return CkFunctions.IsNull<T>(obj);
        }

        public static bool IsNotNull<T>(this T obj)
            where T : class?
        {
            return CkFunctions.IsNotNull<T>(obj);
        }

        public static bool IsNullOrEmpty(this IEnumerable? array)
        {
            return CkFunctions.IsNullOrEmpty(array);
        }

        public static bool IsNotNullOrEmpty(this IEnumerable? array)
        {
            return CkFunctions.IsNotNullOrEmpty(array);
        }
    }
}