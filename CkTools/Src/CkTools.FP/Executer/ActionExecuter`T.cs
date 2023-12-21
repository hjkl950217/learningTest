#pragma warning disable CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS8603 // 可能返回 null 引用。
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。

using System;

namespace CkTools.FP.Executer
{
    /// <summary>
    /// 方法执行器-泛型返回
    /// </summary>
    public class ActionExecuter<TResult> : ActionExecuter
    {
        public TResult Result { get; set; }

        /// <summary>
        /// 初始化<see cref="ActionExecuter{TResult}"/>
        /// </summary>
        protected ActionExecuter() : base()
        {
            this.Result = default;
        }

        #region Init

        /// <summary>
        /// 初始化<see cref="ActionExecuter{TResult}"/>
        /// </summary>
        /// <param name="defaultResultFunc">传递一个委托用于初始化返回值</param>
        /// <returns></returns>
        public static ActionExecuter<TResult> Init(Func<TResult>? defaultResultFunc)
        {
            TResult defaultResult = defaultResultFunc == null ? default : defaultResultFunc();

            return new ActionExecuter<TResult>()
            {
                Result = defaultResult
            };
        }

        /// <summary>
        /// 初始化<see cref="ActionExecuter{TResult}"/>
        /// </summary>
        /// <returns></returns>
        public new static ActionExecuter<TResult> Init()
        {
            return ActionExecuter<TResult>.Init(() => default);
        }

        #endregion Init

        /// <summary>
        /// 执行并获取结果
        /// </summary>
        /// <returns></returns>
        public TResult ExecuteAndResult()
        {
            if(this.IsEnd)
            {
                return this.Result;
            }
            else
            {
                base.Execute();
                return this.Result;
            }
        }
    }

#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
#pragma warning restore CS8603 // 可能返回 null 引用。
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
}