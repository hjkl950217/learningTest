using Microsoft.Extensions.DependencyInjection;
using Nova.LogicChain.Entity;
using System;

namespace Nova.LogicChain
{
    /// <summary>
    /// 步骤链-自动注册标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class LogicChainStepAttribute : Attribute
    {
        /// <summary>
        /// 初始化一个<see cref="LogicChainStepAttribute"/>实例
        /// </summary>
        /// <param name="taskEnumTypeValue">步骤枚举值</param>
        /// <param name="contextResultType">
        /// 表示<see cref="StepContext.Result"/>中的类型。<para></para>
        ///
        /// 如果你继承的是<see cref="IStep"/>，建议指定此属性，提高代码阅读性.
        ///
        /// 如果你继承的是<see cref="IStep{TResult}"/>,则不用指定此属性,框架会自动赋值.<para></para>
        /// </param>
        /// <param name="lifetime">
        /// 表示在DI中的生命周期配置。默认为<see cref="ServiceLifetime.Singleton"/>
        /// </param>
        public LogicChainStepAttribute(
            object taskEnumTypeValue,
            Type contextResultType = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            #region 检测

            taskEnumTypeValue.CheckNull(nameof(taskEnumTypeValue));

            if (taskEnumTypeValue.GetType().IsEnum == false)
            {
                throw new TypeAccessException($"{nameof(LogicChainStepAttribute)} initialization need Enum type.{nameof(taskEnumTypeValue)}'s type is {taskEnumTypeValue.GetType().Name}");
            }

            #endregion 检测

            this.TaskEnumType = taskEnumTypeValue.GetType();
            this.TaskEnumOrder = (int)taskEnumTypeValue;

            this.ContextResultType = contextResultType;
            this.Lifetime = lifetime;
        }

        /// <summary>
        /// 实现步骤类上面的打的步骤枚举类型
        /// </summary>
        public Type TaskEnumType { get; }

        /// <summary>
        /// 实现步骤类上面的打的步骤枚举值
        /// </summary>
        public int TaskEnumOrder { get; }

        /// <summary>
        /// 表示<see cref="StepContext.Result"/>中的类型
        /// </summary>
        public Type ContextResultType { get; set; }

        /// <summary>
        /// 代表步骤实现的生命周期
        /// </summary>
        /// <remarks>
        /// 用来向IOC注册时指定作用域
        /// </remarks>
        public ServiceLifetime Lifetime { get; }
    }
}