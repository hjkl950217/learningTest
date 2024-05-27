using System.Diagnostics.CodeAnalysis;
using CkTools.FP;

namespace CkTools.Nova.Executer
{
    /// <summary>
    /// <see cref="ActionExecuter"/>的扩展
    /// </summary>
    public static class ActionExecuterTExtensions
    {
        #region 其他

        /// <summary>
        /// 重置为初始状态
        /// </summary>
        /// <param name="executer"></param>
        /// <returns></returns>
        public static ActionExecuter Reset<TResult>(
           [NotNull] this ActionExecuter<TResult> executer)
        {
            CkFunctions.CheckNullWithException(executer);
            executer.IsEnd = false;
            executer.Result = default;
            return executer;
        }

        #endregion 其他
    }
}