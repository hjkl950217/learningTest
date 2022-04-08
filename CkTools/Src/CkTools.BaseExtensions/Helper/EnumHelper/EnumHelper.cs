using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using CkTools.BaseExtensions.Model;

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
        private static readonly ConcurrentDictionary<string, Lazy<EnumData>> EnumStructCache = new ConcurrentDictionary<string, Lazy<EnumData>>();

        [return: NotNull]
        private EnumData GetEnumData(Type enumType)
        {
            EnumData result = new EnumData(enumType);

            #region 获得枚举的数据

            result.AttributeArray = enumType
                .GetCustomAttributes<Attribute>()
                .ToArray();

            #endregion 获得枚举的数据

            #region 获得枚举值的数据

            //获得枚举的字段数据
            FieldInfo[] fields = enumType
                 .GetFields(BindingFlags.Static | BindingFlags.Public)
                 ?? Array.Empty<FieldInfo>();
            List<EnumValueData> tempEnumValueDataList = new List<EnumValueData>();

            foreach (FieldInfo? item in fields)
            {
                //解析数据
                object enumValue = item.GetValue(null);
                Type baseValueType = System.Enum.GetUnderlyingType(enumValue.GetType());
                Attribute[] attributeArry = item
                    .GetCustomAttributes<Attribute>()
                    .ToArray();

                //组合
                EnumValueData tempData = new EnumValueData(
                    enumValueName: item.Name,
                    enumValue: (Enum)enumValue,
                    baseValueType: baseValueType,
                    enumType: enumType,
                    attributeArray: attributeArry
                    );

                //保存
                tempEnumValueDataList.Add(tempData);
            }

            result.EnumValueDataArray = tempEnumValueDataList.ToArray();

            #endregion 获得枚举值的数据

            return result;
        }

        [return: NotNull]
        public EnumData GetOrAddEnumCache(Type enumType)
        {
            if (enumType.BaseType != typeof(Enum))
            {
                throw new ArgumentException($"{enumType} 's BaseType must be a subclass of A {typeof(Enum)}", $"{enumType}");
            }

            Lazy<EnumData> result = EnumHelper.EnumStructCache
                 .GetOrAdd(
                     key: enumType.Name,
                     valueFactory: _ => new Lazy<EnumData>(
                         () => this.GetEnumData(enumType))
                     );
            return result.Value;
        }
    }
}