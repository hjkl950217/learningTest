using CkTools.Abstraction.ConstAndEnum;

namespace CkTools.BaseExtensions
{
    public static class GuidFormatEnumExtensions
    {
        /// <summary>
        /// 获取用于格式化的字符串
        /// </summary>
        /// <param name="formatEnum"></param>
        /// <returns></returns>
        public static string GetFormatString(this GuidFormatEnum formatEnum)
        {
            return formatEnum switch
            {
                GuidFormatEnum.N => "N",
                GuidFormatEnum.D => "D",
                GuidFormatEnum.B => "B",
                GuidFormatEnum.P => "P",
                GuidFormatEnum.X => "X",
                _ => throw new System.NotSupportedException(),
            };
        }
    }
}