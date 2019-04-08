using Nova.LogicChain.Entity;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Nova.LogicChain
{
    /// <summary>
    /// <see cref="INovaFactory"/>接口的默认实现
    /// </summary>
    public class NovaFactory : INovaFactory
    {
        /// <summary>
        /// 放存步骤中间件的字典。
        /// <para>key为步骤枚举的类型</para>
        /// <para>value为步骤枚举对应的步骤实现,已经排列好调用顺序，第一个既可执行</para>
        /// </summary>
        private readonly ConcurrentDictionary<Type, StepEntity[]> taskList;

        /// <summary>
        /// DI实例
        /// </summary>
        private readonly IServiceProvider di;

        /// <summary>
        /// 初始化一个 <see cref="NovaFactory"/> 实例
        /// </summary>
        /// <param name="serviceProvider">DI实例</param>
        /// <param name="taskList">
        /// 需要处理的 <see cref="StepEntity"/> 集合。可调用 <see cref="LogicalChainHelper.FindAllTaskEntity"/> 获得
        /// </param>
        public NovaFactory(IServiceProvider serviceProvider, List<StepEntity> taskList)
        {
            this.di = serviceProvider;

            var tempTaskList = this.GetNovaList(taskList);
            this.taskList = new ConcurrentDictionary<Type, StepEntity[]>(tempTaskList);
        }

        /// <summary>
        /// 按<typeparamref name="TEnumType"/>获取第一个可执行的任务实例。
        /// </summary>
        /// <typeparam name="TEnumType"></typeparam>
        /// <returns></returns>
        public IStep GetFirstTask<TEnumType>()
        {
            StepEntity[] taskEntity = this.taskList.GetOrAdd(
                typeof(TEnumType),
                type => this.GetTaskEntity(type)
                );

            return taskEntity
                  .FirstOrDefault()
                  ?.StepInstanceObject;
        }

        #region 获取、排列

        /// <summary>
        /// 获取所有的步骤枚举和对应的实现数据
        /// </summary>
        /// <param name="taskList">帮助整理的<see cref="StepEntity"/>集合。默认返回工厂缓存的数据</param>
        /// <remarks>
        /// 此方法提供给调试时使用，开发使用<see cref="GetFirstTask{TEnumType}"/>方法即可。<para></para>
        /// 如果是启动时调用：会扫描程序集然后注册、添加、排序等等。
        /// 如果是启动后调用：会返回缓存中的数据。
        /// </remarks>
        /// <returns></returns>
        public Dictionary<Type, StepEntity[]> GetNovaList(List<StepEntity> taskList = null)
        {
            if (this.taskList == null || this.taskList.Any() == false)
            {
                //1.获取Type数据
                taskList = taskList ?? this.A_FindAllTaskEntity();

                //2.创建或获取接口
                taskList = this.B_CreateInstance(taskList, this.di);

                //3.排序-排列接口上的Next
                return this.C_SortAndPermutation(taskList);
            }
            else
            {
                return this.taskList.ToDictionary(t => t.Key, t => t.Value);
            }
        }

        /// <summary>
        /// 整理、获取所有的Task
        /// </summary>
        /// <returns></returns>
        private StepEntity[] GetTaskEntity(Type enumType)
        {
            //1.获取Type数据
            List<StepEntity> tempTaskList = this.A_FindAllTaskEntity();

            //2.创建或获取接口
            this.B_CreateInstance(tempTaskList, this.di);

            //3.排序-排列接口上的Next
            //分组-以type为索引
            var taskGroup = tempTaskList.FindAll(t => t.Attribute.TaskEnumType == enumType);

            //排列next属性
            return LogicalChainHelper.SortList(taskGroup);
        }

        /// <summary>
        /// 找出所有程序集中所有包含<see cref="LogicChainStepAttribute"/>的类数据
        /// </summary>
        /// <returns></returns>
        private List<StepEntity> A_FindAllTaskEntity()
        {
            return LogicalChainHelper.FindAllTaskEntity();
        }

        private List<StepEntity> B_CreateInstance(in List<StepEntity> taskList, IServiceProvider di)
        {
            foreach (var item in taskList)
            {
                item.StepInstanceObject = this.CreateInstance<IStep>(item.StepType, di);
            }
            return taskList;
        }

        /// <summary>
        /// 排序后排列next调用
        /// </summary>
        /// <param name="taskList"></param>
        /// <returns></returns>
        private Dictionary<Type, StepEntity[]> C_SortAndPermutation(in List<StepEntity> taskList)
        {
            var taskGroup = taskList
                .ToLookup(t => t.Attribute.TaskEnumType);

            Dictionary<Type, StepEntity[]> result = new Dictionary<Type, StepEntity[]>();
            foreach (var item in taskGroup)
            {
                var temp = LogicalChainHelper.SortList(item.ToList());

                result.Add(item.Key, temp);
            }

            return result;
        }

        #endregion 获取、排列

        #region 创建实例

        /// <summary>
        ///(适合构造方法无参数) 利用框架自带的激活器创建实例.
        /// </summary>
        /// <param name="type">要创建的类型</param>
        /// <param name="di">DI实例</param>
        /// <returns></returns>
        private TInstance CreateInstance<TInstance>(Type type, IServiceProvider di)
            where TInstance : class
        {
            return di.GetService(type) as TInstance;
        }

        /// <summary>
        /// (适合构造方法有参数)利用框架自带的激活器创建实例.
        /// </summary>
        /// <param name="type">要创建的类型</param>
        /// <param name="args">构造方法中要求的参数，按顺序传递</param>
        /// <returns></returns>
        private TInstance CreateInstance<TInstance>(Type type, params object[] args)
         where TInstance : class, new()
        {
            TInstance tempInstance = Activator.CreateInstance(type, args) as TInstance;//利用这个自带的激活器创建，也可以修改为DI实例

            return tempInstance;
        }

        #endregion 创建实例
    }
}