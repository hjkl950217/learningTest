using CkTools.Nova.Entity;
using CkTools.Nova.LogicChain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;

namespace CkTools.Nova.Aop
{
    /// <summary>
    /// 步骤链-自动注册标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    public class StepAttribute : Attribute
    {
        #region 构造方法

        /// <summary>
        /// 初始化一个<see cref="StepAttribute"/>实例
        /// </summary>
        /// <param name="stepEnumValue">步骤枚举值</param>
        public StepAttribute([NotNull] object stepEnumValue)
            : this(stepEnumValue, ServiceLifetime.Singleton) { }

        /// <summary>
        /// 初始化一个<see cref="StepAttribute"/>实例
        /// </summary>
        /// <param name="stepEnumValue">步骤枚举值</param>
        /// <param name="contextResultType">
        /// 表示<see cref="StepContext{TResult}.Result"/>中的类型。<para></para>
        ///
        /// 如果你继承的是<see cref="IStep"/>，建议指定此属性，提高代码阅读性.
        ///
        /// 如果你继承的是<see cref="IStep{TResult}"/>,则不用指定此属性,框架会自动赋值.<para></para>
        /// </param>
        public StepAttribute([NotNull] object stepEnumValue, Type contextResultType)
            : this(stepEnumValue, contextResultType, ServiceLifetime.Singleton) { }

        /// <summary>
        /// 初始化一个<see cref="StepAttribute"/>实例
        /// </summary>
        /// <param name="stepEnumValue">步骤枚举值</param>
        /// <param name="lifetime">
        /// 表示在DI中的生命周期配置。默认为<see cref="ServiceLifetime.Singleton"/>
        /// </param>
        public StepAttribute([NotNull] object stepEnumValue, ServiceLifetime lifetime)
            : this(stepEnumValue, null, lifetime) { }

        /// <summary>
        /// 初始化一个<see cref="StepAttribute"/>实例
        /// </summary>
        /// <param name="stepEnumValue">步骤枚举值</param>
        /// <param name="contextResultType">
        /// 表示<see cref="StepContext{TResult}.Result"/>中的类型。<para></para>
        ///
        /// 如果你继承的是<see cref="IStep"/>，建议指定此属性，提高代码阅读性.
        ///
        /// 如果你继承的是<see cref="IStep{TResult}"/>,则不用指定此属性,框架会自动赋值.<para></para>
        /// </param>
        /// <param name="lifetime">
        /// 表示在DI中的生命周期配置。默认为<see cref="ServiceLifetime.Singleton"/>
        /// </param>
        public StepAttribute(
            [NotNull] object stepEnumValue,
            Type contextResultType,
            ServiceLifetime lifetime)
        {
            #region 检测

            stepEnumValue.CheckNullWithException(nameof(stepEnumValue));

            if (stepEnumValue.GetType().IsEnum == false)

            {
                throw new TypeAccessException($"{nameof(StepAttribute)} initialization need Enum type.{nameof(stepEnumValue)}'s type is {stepEnumValue.GetType().Name}");
            }

            #endregion 检测

            this.StepEnumType = stepEnumValue.GetType();
            this.StepEnumOrder = (int)stepEnumValue;

            this.ContextResultType = contextResultType;
            this.Lifetime = lifetime;
        }

        #endregion 构造方法

        /// <summary>
        /// 实现步骤类上面的打的步骤枚举类型
        /// </summary>
        public Type StepEnumType { get; }

        /// <summary>
        /// 实现步骤类上面的打的步骤枚举值
        /// </summary>
        public int StepEnumOrder { get; }

        /// <summary>
        /// 表示<see cref="StepContext{TResult}.Result"/>中的类型
        /// </summary>
        public Type ContextResultType { get; set; }

        public Enum StepEnumValue { get; set; }

        /// <summary>
        /// 代表步骤实现的生命周期
        /// </summary>
        /// <remarks>
        /// 用来向IOC注册时指定作用域
        /// </remarks>
        public ServiceLifetime Lifetime { get; }

        /*
         * todo:特性重构：
         *
         * 目标：
         * 1. 无返回值的只需要打步骤枚举即可
         * 2. 有返回值的
         *      可以打在实现类上
         *      也可以打在返回结果的类型上面
         *
         *      如果都有，以返回结果的类型上面为准（但是这一点最后可以询问下群里，那种会比较爽）
         *
         *
         * 3.上面修改完成之后，需要修改UT,还有EndStep<>的获取。
         *
         *
         * 影响： 特性类要改名，2种情况的要分开了（可考虑要不要继承）
         *        创建的工厂也需要修改，改查找的地方，然后判断用实现类的还是结果类上面的
         */
    }
}