using System;
using CkTools.Nova.Aop;
using CkTools.Nova.LogicChain;

namespace CkTools.Nova.Entity
{
    /// <summary>
    /// 注册、排序过程中使用的最小单位数据。 框架使用
    /// </summary>
    /// <remarks>
    /// 在注册、排序过程中有很多上下文的关系，这里用一个类装起来。
    /// <para>每个<see cref="StepEntity"/>都是代表单步操作的数据</para>
    /// </remarks>
    public class StepEntity
    {
        /// <summary>
        /// 逻辑链注册的特性
        /// </summary>
        public StepAttribute Attribute { get; set; }

        /// <summary>
        /// 实现类的<see cref="Type"/>数据。
        /// 只会是直接或间接继承<see cref="IStep"/>接口或<see cref="IStep{TResult}"/>接口的类
        /// </summary>
        public Type StepType { get; set; }

        /// <summary>
        /// 步骤实例对象
        /// </summary>
        public IStep StepInstanceObject { get; set; }
    }
}