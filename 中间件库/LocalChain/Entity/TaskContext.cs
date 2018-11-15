using System.Collections.Generic;

namespace Nova.LocalChain.Entity
{
    /// <summary>
    /// 以中间件方式执行逻辑链的上下文
    /// </summary>
    /// <remarks>
    /// 接口处（接口定义、方法定义）等暂时不能使用泛型上下文。
    /// 参数传递、使用中推荐使用<see cref="TaskContext{TResult}"/>
    /// </remarks>
    public abstract partial class TaskContext
    {
        /// <summary>
        /// 初始化<see cref="TaskContext{TResult}"/>实例和和属性
        /// </summary>
        public TaskContext()
        {
            this.ProcessCompleted = false;
            this.ErrorList = new List<TaskError>();
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
        public virtual List<TaskError> ErrorList { get; }

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

    /// <summary>
    /// 以中间件方式执行逻辑链的泛型上下文
    /// </summary>
    public class TaskContext<TResult> : TaskContext
    {
        public TaskContext() : base()
        {
        }

        /// <summary>
        /// 上下文中的返回数据
        /// </summary>
        public override object Result
        {
            get => this.ResultEntiy;
        }

        /// <summary>
        /// 获取当前上下文中的<see cref="Result"/>
        /// </summary>
        /// <returns></returns>
        public TResult ResultEntiy { get; internal set; }
    }
}