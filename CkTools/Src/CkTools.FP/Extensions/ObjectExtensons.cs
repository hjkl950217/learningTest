using CkTools.FP;

namespace System
{
    public static class ObjextExt_CheckNull
    {
        public static bool IsNull<T>(this T obj)
            where T : class?
        {
            return CkFunctions.IsNull(obj);
        }

        public static bool IsNotNull<T>(this T obj)
            where T : class?
        {
            return CkFunctions.IsNotNull(obj);
        }
    }
}