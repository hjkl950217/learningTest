using System;
using System.ComponentModel.DataAnnotations;

namespace CkTools.Attribute
{
    /// <summary>
    /// 标记属性或字段为json格式的字符串
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class JsonStringAttribute : RequiredAttribute
    {
        /// <summary>
        /// 检查数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return value is string v && v.IsJson();
        }

        public override string FormatErrorMessage(string name)
        {
            return $"The {name} field not a json string";
        }
    }
}