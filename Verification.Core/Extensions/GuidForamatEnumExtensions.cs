using Verification.Core.ConstAndEnum;

namespace System
{
    public static class GuidForamatEnumExtensions
    {
        /// <summary>
        /// 获取用于格式化的字符串
        /// </summary>
        /// <param name="foramatEnum"></param>
        /// <returns></returns>
        public static string GetForamatString(this GuidForamatEnum foramatEnum)
        {
            switch (foramatEnum)
            {
                case GuidForamatEnum.N: return "N";
                case GuidForamatEnum.D: return "D";
                case GuidForamatEnum.B: return "B";
                case GuidForamatEnum.P: return "P";
                case GuidForamatEnum.X: return "X";
                default: throw new System.NotSupportedException();
            }
        }
    }
}