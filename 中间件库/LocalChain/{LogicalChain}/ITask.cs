using Nova.LocalChain.Entity;
using System.Threading.Tasks;

namespace Nova.LocalChain
{
    /// <summary>
    /// 以中间件方式执行的任务步骤接口，一个实现对应一步逻辑
    /// </summary>
    public interface ITask
    {
        #region 考虑以后在抽象类中加的东西

        /*
         * 目前已经有2个需要约定的东西了：
         * 1.要打标签，而且标签里面需要是步骤枚举
         * 2.需要继承ITask接口
         *
         *  写在接口中不是不可以，但是需要他在代码中实现接口时手动指定。
         *  才开始弄想弄简单点，跑起来。
         *  后面大家接收程度觉得可以了，再加在接口中
         *
         *  放抽象类里面的话，可以做更多的事，但不如接口清真。
         *
         */

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
        /// 由TaskMwHelper初始化时统一排序和赋值
        /// </remarks>
        ITask Next { get; set; }

        /// <summary>
        /// 异步执行任务
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        Task InvokeAsync(TaskContext context);
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

    /// <summary>
    /// 结束中间件，代表最后一步
    /// </summary>
    public class EndTaskMw : ITask
    {
        /// <summary>
        /// 下一个中间件
        /// </summary>
        /// <remarks>
        /// 由TaskMwHelper初始化时统一排序和赋值
        /// </remarks>
        public ITask Next { get; set; }

        /// <summary>
        /// 直接返回一个<see cref="Task.CompletedTask"/>来结束调用
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task InvokeAsync(TaskContext context)
        {
            return Task.CompletedTask;
        }
    }
}