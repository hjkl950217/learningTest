﻿using System;

namespace CkTools.Abstraction.Model
{
    /// <summary>
    /// 缓存的枚举结构
    /// </summary>
    public class EnumValueData
    {
        private const string BaseValueStringFormatStr = "D";

        public EnumValueData(
            string enumValueName,
            Enum enumValue,
            Type baseValueType,
            Type enumType,
            Attribute[] attributeArray)
        {
            this.EnumValueName = enumValueName;
            this.EnumValue = enumValue;
            this.BaseValueType = baseValueType;
            this.EnumType = enumType;
            this.AttributeArray = attributeArray ?? Array.Empty<Attribute>();

            //额外处理的
            this.BaseValue = Convert.ChangeType(enumValue, baseValueType);
            this.BaseValueString = Enum.Format(enumType, enumValue, BaseValueStringFormatStr);
        }

        /// <summary>
        /// 枚举值的名字，不是枚举名！
        /// </summary>
        public string EnumValueName { get; }

        /// <summary>
        /// 枚举项数据，如果获取值请直接使用<see cref="BaseValue"/>
        /// </summary>
        public Enum EnumValue { get; }

        /// <summary>
        /// 枚举的基础类型数据
        /// </summary>
        public Type BaseValueType { get; }

        /// <summary>
        /// 枚举本身的类型数据
        /// </summary>
        public Type EnumType { get; }

        /// <summary>
        /// 枚举值对应的基础类型值
        /// </summary>
        public object BaseValue { get; }

        /// <summary>
        /// 枚举值对应的基础类型值-string格式
        /// </summary>
        public string BaseValueString { get; }

        /// <summary>
        /// 获取枚举值，上面的特性
        /// </summary>
        public Attribute[] AttributeArray { get; }
    }
}