namespace CkTools
{
    /// <summary>
    /// 业务验证中的错误实体
    /// </summary>
    public class BizError<T> : BizError
       where T : class
    {
        public T? ErrorObject { get; set; }
    }
}