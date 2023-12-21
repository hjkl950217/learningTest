namespace CkTools.FP
{
    /// <summary>
    /// 占位使用的类型，无内容<br/>
    /// FP中有些高级功能会编写一个基础的函数，类型比较多。
    /// 然后提供同功能更少参数API时，可能使用它来表示占位
    /// </summary>
    public class NoneObject
    {
        private NoneObject()
        {
        }

        /// <summary>
        /// 占位用的空对象
        /// </summary>
        public static NoneObject None = new();
    }
}