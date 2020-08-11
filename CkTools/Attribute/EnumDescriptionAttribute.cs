using System;

namespace CkTools
{
    /// <summary>
    /// 枚举上的描述-用于扩展自带枚举的功能
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property | AttributeTargets.Field,
        AllowMultiple = false,
        Inherited = false)]
    public sealed class EnumDescriptionAttribute : FlagsAttribute
    {
        /// <summary>
        /// 初始化一个<see cref="EnumDescriptionAttribute"/>实例
        /// </summary>
        /// <param name="Description">自定义的描述</param>
        /// <param name="DbValue">对应DB中的值</param>
        /// <param name="ShowValue">显示用的值</param>
        public EnumDescriptionAttribute(
            string? ShowValue = null,
            string? DbValue = null,
            string? Description = null)
        {
            this.ShowValue = ShowValue;
            this.DBValue = DbValue;
            this.Description = Description;
        }

        /// <summary>
        /// 自定义的描述
        /// </summary>
        public string? Description { get; }

        /// <summary>
        /// 对应DB中的值
        /// </summary>
        /// <remarks>
        /// 数据库中存的值，一般为char类型
        /// </remarks>
        public string? DBValue { get; }

        /// <summary>
        /// 显示用的值
        /// </summary>
        public string? ShowValue { get; }
    }
}