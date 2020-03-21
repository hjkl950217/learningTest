using System;

namespace Verification.Core.Extensions.BaseType
{
    public static class EnumExtension
    {
        /// <summary>
        /// Get enum name.
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumName(this Enum enumValue)
        {
            return Enum.GetName(enumValue.GetType(), enumValue);
        }
    }
}