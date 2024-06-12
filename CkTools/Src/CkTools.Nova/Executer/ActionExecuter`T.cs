using System;

namespace CkTools.Nova.Executer
{
    /// <summary>
    /// 方法执行器-泛型返回
    /// </summary>
    public class ActionExecuter<TResult> : ActionExecuter
    {
        public TResult? Result { get; set; }

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
        /// <returns></returns>
        public new static ActionExecuter<TResult?> Init()
        {
            return ActionExecuter<TResult?>.Init(() => default);
        }

        /// <summary>
        /// 初始化<see cref="ActionExecuter{TResult}"/>
        /// </summary>
        /// <param name="defaultResultFunc">传递一个委托用于初始化返回值</param>
        /// <returns></returns>
        public static ActionExecuter<TResult?> Init(Func<TResult> defaultResultFunc)
        {
            TResult? defaultResult = defaultResultFunc == null ? default : defaultResultFunc();

            return new ActionExecuter<TResult?>()
            {
                Result = defaultResult
            };
        }

        #endregion Init

        /// <summary>
        /// 执行并获取结果
        /// </summary>
        /// <returns></returns>
        public TResult? ExecuteAndResult()
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

    public class IdGenerator
    {
        private readonly ActionExecuter<string> executer;
        private string companyId = string.Empty;
        private string name = string.Empty;
        private string age = string.Empty;

        //假定传递进来的查询参数，dbCtx为数据库上下文对象，companyName为公司名称
        public IdGenerator(string companyName, object dbCtx)
        {
            this.executer = ActionExecuter<string>.Init("0000");//初始化默认返回值 也可以不传

            this.executer
                .Pipe(this.SetCompanyId)
                .Pipe(this.SetName)
                .Pipe(this.SetAge)
                .Pipe(this.BuildId);
        }

        //对外暴露的 方法
        public string GetId() => this.executer.ExecuteAndResult();

        //内部的步骤方法
        private void SetCompanyId() => this.companyId = "cd";//假定读取过数据库后获取到的公司Id为"cd"

        private void SetName() => this.name = "zs";

        private void SetAge() => this.age = "25";

        private void BuildId() => this.executer.Result = $"{this.companyId}{this.name}{this.age}";//设置结果
    }
}