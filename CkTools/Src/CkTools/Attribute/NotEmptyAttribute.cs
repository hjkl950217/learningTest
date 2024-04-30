using System;
using System.ComponentModel.DataAnnotations;

namespace CkTools.Attribute
{
    /// <summary>
    /// 标记属性或字段为必填且不能为空数组
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class NotEmptyAttribute : RequiredAttribute
    {
        /// <summary>
        /// 检查数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return value.IsNotNullOrEmpty();
        }

        public override string FormatErrorMessage(string name)
        {
            return $"The {name} field is empty";
        }
    }
}