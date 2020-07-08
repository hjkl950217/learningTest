using System;
using System.Diagnostics.CodeAnalysis;

namespace Verification.Core.Helper
{
    public interface IEnumHelper
    {
        /// <summary>
        /// 获取或添加枚举数据。数据源为 (私有)EnumHelper.EnumStructCache
        /// </summary>
        /// <typeparam name="TEnum">枚举的类型</typeparam>
        /// <returns></returns>
        [return: NotNull]
        EnumAttributeData[] GetAllEnumAttributeData<TEnum>() where TEnum : Enum;
    }
}