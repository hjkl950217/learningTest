using System;
using System.Collections.Generic;

namespace CkTools.FP.Executer
{
    /// <summary>
    /// 方法执行器
    /// </summary>
    public class ActionExecuter
    {
        #region 属性区

        public List<Action> StepList { get; internal set; }
        public static Action NullAction = () => { };

        /// <summary>
        /// 是否结束管道,true时执行后续节点,false时结束执行
        /// </summary>
        public bool IsEnd { get; internal set; }

        #endregion 属性区

        /// <summary>
        /// 初始化<see cref="ActionExecuter"/>
        /// </summary>
        protected ActionExecuter()
        {
            this.StepList = new List<Action>();
            this.IsEnd = false;
        }

        #region Init

        /// <summary>
        /// 初始化<see cref="ActionExecuter"/>
        /// </summary>
        public static ActionExecuter Init()
        {
            return new ActionExecuter();
        }

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

        #endregion Init

        /// <summary>
        /// 执行
        /// </summary>
        public virtual void Execute()
        {
            if (this.IsEnd) return;//用于幂等判定，结束后不再执行

            //执行中间步骤
            foreach (Action action in this.StepList)
            {
                action();
                if (this.IsEnd) return;//方法执行后结束则直接返回
            }

            this.IsEnd = true;//用于幂等判定，结束后不再执行
        }
    }
}