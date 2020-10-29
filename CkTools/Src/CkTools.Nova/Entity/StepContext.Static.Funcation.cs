namespace CkTools.Nova.Entity
{
    //一些静态方法
    //类似微软一样，Task.XX()
    public abstract partial class StepContext
    {
        /// <summary>
        /// 一个<see cref="DefualtNullResult"/>,无于返回值的场景。
        /// </summary>
        public static readonly NullResult DefualtNullResult = new NullResult();

        #region 创建StepContext

        ///// <summary>
        ///// （未启用）创建一个新的<see cref="StepContext{TResult}"/>.
        ///// <para><typeparamref name="TResult"/>里面的数据初始化部分不会负责</para>
        ///// </summary>
        ///// <remarks>
        ///// 此功能需要配合自动注册，暂未开发
        ///// </remarks>
        ///// <typeparam name="TResult">上下文中返回的类型</typeparam>
        ///// <param name="di">DI实例</param>
        ///// <returns></returns>
        //public static StepContext<TResult> CreateContext<TResult>(IServiceProvider di)
        //    where TResult:class
        //{
        //    Type strType = typeof(TResult);//获取泛型的结构
        //    Type genericType = typeof(StepContext<>);//获取泛型上下文定义的结构
        //    Type genericType2 = genericType.MakeGenericType(strType);//创建泛型上下文接口

        //    //获取实例
        //    StepContext<TResult> taskContext = di.GetService(genericType2) as StepContext<TResult>;

        //    //初始化结果数据
        //    bool isNullResult = taskContext.Result.GetHashCode() == new object().GetHashCode();
        //    if (isNullResult)
        //    {
        //        taskContext.ResultEntiy = di.GetService<TResult>();
        //    }

        //    return taskContext;
        //}

        ///// <summary>
        ///// 创建一个新的<see cref="StepContext{TResult}"/>.
        ///// <para><typeparamref name="TResult"/>里面的数据初始化部分不会负责</para>
        ///// </summary>
        ///// <typeparam name="TResult">上下文中返回的类型</typeparam>
        ///// <returns></returns>
        //public static StepContext<TResult> CreateContext<TResult>()
        //    where TResult : class
        //{
        //    StepContext<TResult> tt = new StepContext<TResult>
        //    {
        //        ResultEntiy = default
        //    };

        //    return tt;
        //}

        /// <summary>
        /// 创建一个新的<see cref="StepContext{TResult}"/>.
        /// </summary>
        /// <typeparam name="TResult">上下文中结果的类型</typeparam>
        /// <param name="initObject">要初始化到上下文中的结果</param>
        /// <param name="completed">
        /// 表示初始化后的上下文是否已经完成任务。用来初始化<see cref="CkTools.Nova.Entity.StepContext.ProcessCompleted"/>属性
        /// </param>
        /// <returns>初始化后的<see cref="StepContext{TResult}"/></returns>
        public static StepContext<TResult> CreateContext<TResult>(
            TResult initObject,
            bool completed = false)
            where TResult : class
        {
            StepContext<TResult> context = new StepContext<TResult>(initObject, completed);

            return context;
        }

        /// <summary>
        /// 创建一个新的<see cref="CkTools.Nova.Entity.StepContext"/>.
        /// </summary>
        /// <param name="completed">
        /// 表示初始化后的上下文是否已经完成任务。用来初始化<see cref="CkTools.Nova.Entity.StepContext.ProcessCompleted"/>属性
        /// </param>
        /// <returns>初始化后的<see cref="CkTools.Nova.Entity.StepContext"/></returns>
        public static CkTools.Nova.Entity.StepContext CreateContext(bool completed = false)
        {
            return CkTools.Nova.Entity.StepContext.CreateContext<NullResult>(CkTools.Nova.Entity.StepContext.DefualtNullResult, completed);
        }

        #endregion 创建StepContext
    }
}