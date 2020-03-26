using System;

namespace Verification.Core.Extensions.BaseType
{
    public static class IntExtensions
    {
        public static T ToEnum<T>(this int value)
            where T : struct
        {
            var enumObj = Enum.ToObject(typeof(T), value);
            if (enumObj != null)
            {
                return (T)(enumObj);
            }
            return default(T);
        }
    }
}