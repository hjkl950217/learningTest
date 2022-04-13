using System;
using System.Diagnostics.CodeAnalysis;
using CkTools.BaseExtensions.Model;

namespace CkTools.Helper
{
    public interface IEnumHelper
    {
        /// <summary>
        /// 获取或添加枚举数据
        /// </summary>
        /// <param name="enumType">枚举的类型</param>
        /// <returns></returns>
        [return: NotNull]
        EnumData GetOrAddEnumCache(Type enumType);
    }
}