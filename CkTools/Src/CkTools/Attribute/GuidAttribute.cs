using System;
using System.ComponentModel.DataAnnotations;

namespace CkTools.Attribute
{
    /// <summary>
    /// 标记属性必须是GUID
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class GuidAttribute : ValidationAttribute
    {
        /// <summary>
        /// GUID的长度
        /// </summary>
        public const int GuidLength = 36;

        public override bool IsValid(object value)
        {
            return value switch
            {
                null => false,
                "" => false,

                string guid
                    when guid.Length == GuidLength && guid.Contains("-") => true,
                _ => false
            };
        }

        public override string FormatErrorMessage(string name)
        {
            return $"The {name} field not a GUID";
        }
    }
}