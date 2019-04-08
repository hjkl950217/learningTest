using Nova.LogicChain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Nova.LogicChain
{
    /// <summary>
    /// 逻辑链帮助类
    /// </summary>
    public static class LogicalChainHelper
    {
        #region 筛选

        /// <summary>
        /// 从载入的程序集中查找 <typeparamref name="TAttribute"/>
        /// </summary>
        /// <example>
        /// predicate参数示例：
        /// <para></para>
        /// <![CDATA[Func<Type, bool> func = i =>{ return i.IsClass && i.IsPublic ; };]]>
        /// </example>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="predicate">用来过滤type的委托</param>
        /// <returns></returns>
        public static IList<(TAttribute attribute, Type Type)> GetCustomAttributesByAssemblies<TAttribute>(Func<Type, bool> predicate)
            where TAttribute : Attribute
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                 .SelectMany(i =>
                 {
                     try
                     {
                         return i.GetExportedTypes();
                     }
                     catch
                     {
                         return new Type[0];
                     }
                 })
               .Where(predicate)
               .Select(type => (Attribute: type.GetCustomAttribute<TAttribute>(false), type))
               .Where(attr => attr.Attribute != null)
               .ToList()
               ;

            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //   .SelectMany(i =>
            //   {
            //       try
            //       {
            //           return i.GetExportedTypes();
            //       }
            //       catch
            //       {
            //           return new Type[0];
            //       }
            //   })
            //   .Where(predicate)
            //   .SelectMany(type => type
            //               .GetCustomAttributes<TAttribute>()
            //               .Select(attr => (attr, type)
            //               )

            //   );

            return types;
        }

        /// <summary>
        /// 找出所有程序集中所有包含<see cref="LogicChainStepAttribute"/>的类数据
        /// </summary>
        /// <returns></returns>
        public static List<StepEntity> FindAllTaskEntity()
        {
            Func<Type, bool> func = i =>
            {
                return i.IsClass //类
                       && i.IsPublic //公共的
                                     //&& i.IsGenericType == false //泛型类型
                                     // && i.IsGenericTypeDefinition == false//泛型具体实现
                                     // && i.IsAbstract == false //抽象

                       ;
            };

            List<StepEntity> taskStructList = LogicalChainHelper
                .GetCustomAttributesByAssemblies<LogicChainStepAttribute>(func)
                .Select(t => new StepEntity() { StepType = t.Type, Attribute = t.attribute })
                .ToList();
            return taskStructList;
        }

        #endregion 筛选

        #region 排列接口

        /// <summary>
        /// 按输入的<see cref="IEnumerable{TaskStruct}"/>排列。
        /// <para>适合已经筛选出一个业务下面的步骤。</para>
        /// </summary>
        /// <param name="taskArray">需要排序的<see cref="StepEntity"/>迭代器</param>
        /// <param name="isAutoEnd">
        /// 是否自动添加结尾的中间件，用来标记执行结束.因为排序时有可能是自动排序，有可能是手动排序，所以此方法不能确定最后一个<see cref="IStep.Next"/>的情况。
        /// 传递false时会自动附加一个空的<see cref="IStep"/>以防止空指针异常
        /// </param>
        /// <returns>排好顺序后，第一个可执行的<see cref="IStep"/></returns>
        public static IStep Sort(
           IEnumerable<StepEntity> taskArray,
           bool isAutoEnd = true)
        {
            return LogicalChainHelper.SortList(taskArray, true)[0].StepInstanceObject;
        }

        /// <summary>
        /// 按输入的<see cref="IEnumerable{TaskStruct}"/>排列。
        /// <para>适合已经筛选出一个业务下面的步骤。</para>
        /// </summary>
        /// <param name="taskArray">需要排序的<see cref="StepEntity"/>迭代器</param>
        /// <param name="isAutoEnd">
        /// 是否自动添加结尾的中间件，用来标记执行结束.因为排序时有可能是自动排序，有可能是手动排序，所以此方法不能确定最后一个<see cref="IStep.Next"/>的情况。
        /// 传递false时会自动附加一个空的<see cref="IStep"/>以防止空指针异常
        /// </param>
        /// <returns>排列好顺序和next调用的<see cref="IStep"/>数组</returns>
        public static StepEntity[] SortList(
           IEnumerable<StepEntity> taskArray,
           bool isAutoEnd = true)
        {
            //排序- 一组接口内部排序
            var taskList = taskArray
                .OrderBy(i => i.Attribute.TaskEnumOrder)
                .ToArray();

            StepEntity tempMw = taskList.First();//获取第一个中间件的引用
            foreach (var item in taskList)
            {
                tempMw.StepInstanceObject.Next = item.StepInstanceObject;
                tempMw = item;//将指针移动到下一个
            }

            //处理最后一个中间件的next。 分析完成后tempMw指向最后一个中间件
            tempMw.StepInstanceObject.Next = isAutoEnd 
                ? new EndStep()
                : null;

            return taskList;
        }

        #endregion 排列接口
    }
}