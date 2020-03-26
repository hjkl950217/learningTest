using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Verification.Core.Helper
{
    /// <summary>
    /// 内部枚举帮助类
    /// </summary>
    public class EnumHelper : IEnumHelper
    {
        protected EnumHelper()
        {
        }

        public static EnumHelper Instance = new EnumHelper();

        /// <summary>
        /// 枚举结构缓存
        /// </summary>
        private static readonly ConcurrentDictionary<string, EnumAttributeData[]> EnumStructCache = new ConcurrentDictionary<string, EnumAttributeData[]>();

        /// <summary>
        /// 提取枚举的结构
        /// </summary>
        /// <param name="enumType">枚举的Type数据</param>
        /// <returns></returns>
        [return: NotNull]
        protected EnumAttributeData[] BuildEnumAttributeDatas(Type enumType)
        {
            //获得枚举的字段数据
            FieldInfo[] fields = enumType
                 .GetFields(BindingFlags.Static | BindingFlags.Public)
                 ?? Array.Empty<FieldInfo>();
            EnumAttributeData[] enumDataList = new EnumAttributeData[fields.Length];

            for (int i = 0 ; i < fields.Length ; i++)
            {
                //解析数据
                object enumValue = fields[i].GetValue(null);
                Type baseValueType = Enum.GetUnderlyingType(enumValue.GetType());
                Attribute[] attributeArry = fields[i]
                    .GetCustomAttributes<Attribute>()
                    .ToArray();

                //组合
                EnumAttributeData tempData = new EnumAttributeData(
                    enumValueName: fields[i].Name,
                    enumValue: (Enum)enumValue,
                    baseValueType: baseValueType,
                    enumType: enumType,
                    attributeArray: attributeArry
                    );

                //保存
                enumDataList[i] = tempData;
            }

            return enumDataList;
        }

        /// <summary>
        /// 获取或添加枚举数据。数据源为 (私有)EnumHelper.EnumStructCache
        /// </summary>
        /// <param name="enumType">枚举的Type数据</param>
        /// <returns></returns>
        [return: NotNull]
        public EnumAttributeData[] GetAllEnumAttributeData([NotNull]Type enumType)
        {
            var result = EnumHelper.EnumStructCache
                 .GetOrAdd(
                     key: enumType.Name,
                     valueFactory: _ => this.BuildEnumAttributeDatas(enumType));

            return result;
        }
    }
}