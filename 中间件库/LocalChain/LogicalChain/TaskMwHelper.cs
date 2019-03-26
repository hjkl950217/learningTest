//using System.Linq;

//namespace Nova.LocalChain
//{
//    /// <summary>
//    /// 还没想好名字的帮助类
//    /// </summary>
//    public class TaskHelper
//    {
//        /// <summary>
//        /// 按输入顺序排列每个ITaskMw中的下一个中间件，会自动设置执行顺序。
//        /// </summary>
//        /// <param name="taskList"></param>
//        /// <returns>
//        /// 排好顺序后，第一个执行的中间件
//        /// </returns>
//        /// <remarks>
//        /// 关于最后一个中间件：<para></para>
//        /// 这种方式
//        ///
//        /// 但是因执行限制，请自行控制最后一个中间件的Next属性，避免运行时造成空指针异常<para></para>
//        /// </remarks>
//        public ITask SortByUse(params ITask[] taskList)
//        {
//            ITask tempMw = taskList.FirstOrDefault();
//            foreach (var item in taskList)
//            {
//                tempMw.Next = item;
//                tempMw = item;//将指针移动到下一个
//            }

//            return taskList[0];
//        }
//    }
//}