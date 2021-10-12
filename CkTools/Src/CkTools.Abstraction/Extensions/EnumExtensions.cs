namespace System
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取枚举值对应的名字
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumName(this Enum enumValue)
        {
            return Enum.GetName(enumValue.GetType(), enumValue);
        }
    }
}