using System;

namespace CkTools.Abstraction.Model
{
    public class EnumData
    {
        /// <summary>
        ///
        /// </summary>
        public EnumData(Type enumType)
        {
            this.Name = enumType.Name;
            this.EnumType = enumType;
            this.AttributeArray = Array.Empty<Attribute>();
            this.EnumValueDataArray = Array.Empty<EnumValueData>();
        }

        /// <summary>
        /// 枚举的名字
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 枚举本身的类型数据
        /// </summary>
        public Type EnumType { get; }

        /// <summary>
        /// 获取枚举值，上面的特性
        /// </summary>
        public Attribute[] AttributeArray { get; set; }

        /// <summary>
        /// 枚举值的数据
        /// </summary>
        public EnumValueData[] EnumValueDataArray { get; set; }
    }
}