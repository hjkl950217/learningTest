using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.Helper
{
    public interface IEnumHelper
    {
        /// <summary>
        /// 获取或添加枚举数据。数据源为 (私有)EnumHelper.EnumStructCache
        /// </summary>
        /// <param name="enumType">枚举的类型</param>
        /// <returns></returns>
        [return: NotNull]
        EnumAttributeData[] GetAllEnumAttributeData(Type enumType);
    }
}