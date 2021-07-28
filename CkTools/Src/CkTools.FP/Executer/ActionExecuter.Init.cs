using System;

namespace CkTools.FP.Executer
{
    public partial class ActionExecuter
    {
        //本文件负责初始化的静态方法

        #region 无返回

        /// <summary>
        /// 初始化<see cref="ActionExecuter"/>
        /// </summary>
        public static ActionExecuter Init()
        {
            return new ActionExecuter();
        }

        #endregion 无返回

        #region 泛型返回

        /// <summary>
        /// 初始化<see cref="ActionExecuter{TResult}"/>
        /// </summary>
        /// <param name="defaultResultFunc">传递一个委托用于初始化返回值</param>
        /// <returns></returns>
        public static ActionExecuter<TResult> Init<TResult>(Func<TResult>? defaultResultFunc)
        {
            return ActionExecuter<TResult>.Init(defaultResultFunc);
        }

        /// <summary>
        /// 初始化<see cref="ActionExecuter{TResult}"/>
        /// </summary>
        /// <param name="defaultResult">传递一个用于初始化返回值</param>
        /// <returns></returns>
        public static ActionExecuter<TResult> Init<TResult>(TResult defaultResult)
        {
            return ActionExecuter<TResult>.Init(() => defaultResult);
        }

        /// <summary>
        /// 初始化<see cref="ActionExecuter{TResult}"/>
        /// </summary>
        /// <returns></returns>
        public static ActionExecuter<TResult> Init<TResult>() where TResult : class, new()

        {
            return ActionExecuter<TResult>.Init(() => new TResult());
        }

        #endregion 泛型返回
    }
}