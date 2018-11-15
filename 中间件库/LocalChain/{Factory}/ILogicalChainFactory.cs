using Nova.LocalChain.Entity;
using System;
using System.Collections.Generic;

namespace Nova.LocalChain
{
    /// <summary>
    /// 逻辑链工厂接口
    /// </summary>
    public interface INovaFactory
    {
        /// <summary>
        /// 按不同的步骤枚举类型，获取第一个可执行的步骤实现
        /// </summary>
        /// <typeparam name="TEnumType"></typeparam>
        /// <returns></returns>
        ITask GetFirstTask<TEnumType>();

        /// <summary>
        /// 获取所有的步骤枚举和对应的实现数据
        /// </summary>
        /// <param name="taskList">帮助整理的<see cref="TaskEntity"/>集合。默认返回工厂缓存的数据</param>
        /// <remarks>
        /// 此方法提供给调试时使用，开发使用<see cref="GetFirstTask{TEnumType}"/>方法即可。<para></para>
        /// 如果是启动时调用：会扫描程序集然后注册、添加、排序等等。
        /// 如果是启动后调用：会返回缓存中的数据。
        /// </remarks>
        /// <returns></returns>
        Dictionary<Type, TaskEntity[]> GetNovaList(List<TaskEntity> taskList = null);
    }
}