using Microsoft.Extensions.DependencyInjection;
using Nova.LogicChain.Entity;
using System;

namespace Nova.LogicChain
{
    /// <summary>
    /// 逻辑链-自动注册标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class LogicChainStepAttribute : Attribute
    {
        /// <summary>
        /// 初始化一个<see cref="LogicChainStepAttribute"/>实例
        /// </summary>
        /// <param name="taskEnumTypeValue">步骤枚举值</param>
        /// <param name="contextResultType"></param>
        /// <param name="lifetime">表示在DI中的生命周期配置。默认为<see cref="ServiceLifetime.Singleton"/></param>
        public LogicChainStepAttribute(
            object taskEnumTypeValue,
            Type contextResultType,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            #region 检测

            if (taskEnumTypeValue == null)
            {
                throw new ArgumentNullException(nameof(taskEnumTypeValue));
            }

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
        /// 记录<see cref="StepContext{TResult}"/>中的类型
        /// </summary>
        public Type ContextResultType { get; set; }

        /// <summary>
        /// 代表步骤实现的生命周期
        /// </summary>
        public ServiceLifetime Lifetime { get; }//此属性可向IOC指定是什么作用域
    }
}