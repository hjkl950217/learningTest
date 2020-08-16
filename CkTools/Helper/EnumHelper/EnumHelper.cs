using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace CkTools.Helper
{
    /// <summary>
    /// 内部枚举帮助类
    /// </summary>
    public class EnumHelper : IEnumHelper
    {
        protected EnumHelper()
        {
        }

        public static IEnumHelper Instance = new EnumHelper();

        /// <summary>
        /// 枚举结构缓存
        /// </summary>
        /// <Value>
        /// <para>Key:枚举类名</para>
        /// <para>Value:每个枚举值的结构数据</para>
        /// </Value>
        private static readonly ConcurrentDictionary<string, Lazy<EnumAttributeData[]>> EnumStructCache = new ConcurrentDictionary<string, Lazy<EnumAttributeData[]>>();

        /// <summary>
        /// 提取枚举的结构
        /// </summary>
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

        [return: NotNull]
        public EnumAttributeData[] GetAllEnumAttributeData(Type enumType)
        {
            if (enumType.BaseType != typeof(Enum))
            {
                throw new ArgumentException($"{enumType} 's BaseType must be a subclass of A {typeof(Enum)}", $"{enumType}");
            }

            Lazy<EnumAttributeData[]> result = EnumHelper.EnumStructCache
                 .GetOrAdd(
                     key: enumType.Name,
                     valueFactory: _ => new Lazy<EnumAttributeData[]>(
                         () => this.BuildEnumAttributeDatas(enumType))
                     );
            return result.Value;
        }
    }
}