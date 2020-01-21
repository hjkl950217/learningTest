namespace Verification.Core
{
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