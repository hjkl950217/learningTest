namespace Verification.Core
{
    /// <summary>
    /// 业务验证中的错误实体
    /// </summary>
    public class BizError<T> : BizError
       where T : class
    {
        public override object CustomObject
        {
            get => this.ErrorObject;
            set => this.ErrorObject = value as T;
        }

        public T ErrorObject { get; set; }
    }
}