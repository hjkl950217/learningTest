using System;

namespace CkTools.Extensions.BaseType
{
    public static class IntExtensions
    {
        public static T ToEnum<T>(this int value)
            where T : struct
        {
            object? enumObj = Enum.ToObject(typeof(T), value);
            if (enumObj != null)
            {
                return (T)(enumObj);
            }
            return default(T);
        }

        /// <summary>
        /// 获取绝对值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Abs(this int value)
        {
            return value < 0 ? 0 - value : value;
        }
    }
}