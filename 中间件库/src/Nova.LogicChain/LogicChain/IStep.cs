using Nova.LogicChain.Entity;
using System.Threading.Tasks;

namespace Nova.LogicChain
{
    /// <summary>
    /// 以中间件方式执行的任务步骤接口，一个实现对应一步逻辑
    /// </summary>
    public interface IStep
    {
        #region 考虑以后在抽象类中加的东西

        ///// <summary>
        ///// 执行顺序
        ///// </summary>
        ///// <remarks>
        ///// 自动排序时使用。<para></para>
        ///// 如果初始化时使用的是TaskMwHelper.SortByUse方式，则不会用到此属性
        ///// </remarks>
        //int ExecuteOrder { get; set; }

        ///// <summary>
        ///// 每个步骤的名字，方便追查
        ///// </summary>
        //string EnumStepName { get; set; }

        #endregion 考虑以后在抽象类中加的东西

        /// <summary>
        /// 下一个中间件
        /// </summary>
        /// <remarks>
        /// 由<see cref="LogicalChainHelper"/>中排序或初始化时统一指定
        /// </remarks>
        IStep Next { get; set; }

        /// <summary>
        /// 异步执行任务
        /// </summary>
        /// <param name="context">要处理的步骤上下文.</param>
        /// <remarks>
        /// 参数初始化：<para></para>
        /// 一般来说第一个步骤代码执行时不会判断null，由调用者负责初始化化。如果使用IOC，则不需要关心此参数
        /// </remarks>
        /// <returns></returns>
        Task InvokeAsync(StepContext context);
    }

    /*
     * 以后的考虑
     *
     * 自动检查是否跳过当前Task
     * 自动检查是否继续
     *
     * 继续抽象其它的设计模式或好的思想
     *
     * 进阶-组合不同的设计模式+思想，抽象出来
     *
     */
}