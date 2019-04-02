using Microsoft.Extensions.DependencyInjection;
using System;

namespace Nova.LogicChain.Entity
{
    public partial class TaskContext
    {
        //一些静态方法
        //类似微软一样，Task.XX()

        #region 创建TaskContext

        /// <summary>
        /// （未启用）创建一个新的<see cref="TaskContext{TResult}"/>.
        /// <para><typeparamref name="TResult"/>里面的数据初始化部分不会负责</para>
        /// </summary>
        /// <remarks>
        /// 此功能需要配合自动注册，暂未开发
        /// </remarks>
        /// <typeparam name="TResult">上下文中返回的类型</typeparam>
        /// <param name="di">DI实例</param>
        /// <returns></returns>
        public static TaskContext<TResult> CreateContext<TResult>(IServiceProvider di)
        {
            Type strType = typeof(TResult);//获取泛型的结构
            Type genericType = typeof(TaskContext<>);//获取泛型上下文定义的结构
            Type genericType2 = genericType.MakeGenericType(strType);//创建泛型上下文接口

            //获取实例
            TaskContext<TResult> taskContext = di.GetService(genericType2) as TaskContext<TResult>;

            //初始化结果数据
            bool isNullResult = taskContext.Result.GetHashCode() == new object().GetHashCode();
            if (isNullResult == true)
            {
                taskContext.ResultEntiy = di.GetService<TResult>();
            }

            return taskContext;
        }

        /// <summary>
        /// 创建一个新的<see cref="TaskContext{TResult}"/>.
        /// <para><typeparamref name="TResult"/>里面的数据初始化部分不会负责</para>
        /// </summary>
        /// <typeparam name="TResult">上下文中返回的类型</typeparam>
        /// <returns></returns>
        public static TaskContext<TResult> CreateContext<TResult>()
        {
            TaskContext<TResult> tt = new TaskContext<TResult>
            {
                ResultEntiy = default
            };

            return tt;
        }

        /// <summary>
        /// 创建一个新的<see cref="TaskContext{TResult}"/>.
        /// <para><typeparamref name="TResult"/>里面的数据初始化部分不会负责</para>
        /// </summary>
        /// <typeparam name="TResult">上下文中返回的类型</typeparam>
        /// <param name="initObject">初始化好的结果数据</param>
        /// <returns></returns>
        public static TaskContext<TResult> CreateContext<TResult>(TResult initObject)
        {
            TaskContext<TResult> taskContext = new TaskContext<TResult>
            {
                ResultEntiy = initObject
            };

            return taskContext;
        }

        #endregion 创建TaskContext
    }
}