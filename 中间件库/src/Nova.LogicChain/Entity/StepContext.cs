using System.Collections.Generic;

namespace Nova.LogicChain.Entity
{
    /// <summary>
    /// 以中间件方式执行逻辑链的上下文
    /// </summary>
    /// <remarks>
    /// 接口处（接口定义、方法定义）等暂时不能使用泛型上下文。
    /// 参数传递、使用中推荐使用<see cref="StepContext{TResult}"/>
    /// </remarks>
    public abstract partial class StepContext
    {
        /// <summary>
        /// 初始化<see cref="StepContext{TResult}"/>实例和和属性
        /// </summary>
        protected StepContext()
        {
            this.ProcessCompleted = false;
            this.ErrorList = new List<StepError>();
            this.Result = new object();
        }

        /// <summary>
        /// 是否分析完成
        /// </summary>
        public virtual bool ProcessCompleted { get; set; }

        /// <summary>
        /// 执行失败时或业务中处理失败的错误消息集合
        /// </summary>
        /// <remarks>
        /// 当任务执行时发生异常时写入
        /// </remarks>
        public virtual List<StepError> ErrorList { get; }

        /// <summary>
        /// 上下文中的返回数据
        /// </summary>
        public virtual object Result { get; internal set; }

        /// <summary>
        /// 获取当前上下文中的<see cref="Result"/>
        /// </summary>
        /// <returns></returns>
        public virtual object GetResult()
        {
            return this.Result;
        }
    }
}