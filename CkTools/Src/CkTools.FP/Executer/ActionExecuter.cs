using System;
using System.Collections.Generic;

namespace CkTools.FP.Executer
{
    /// <summary>
    /// 方法执行器-无返回
    /// </summary>
    public partial class ActionExecuter
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