namespace 技术点验证
{
    /// <summary>
    /// 值对象基类-用于值类型是class<para></para>
    /// 可保证数据不能为null，数据正确(需重写<see cref="BizCheckValue"/>方法以完成业务规则检测)<para></para>
    /// 使用时可以当普通数据使用，如: int a=new Age(50)
    /// </summary>
    /// <remarks>
    /// 微软关于值对象的资料:https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects
    /// </remarks>
    /// <typeparam name="TValue"></typeparam>
    public abstract class ValueObjectBase<TValue> : ValueBase<TValue>, IValueObject<TValue>
        where TValue : class
    {
        //其它人关于class 值类型的处理  https://enterprisecraftsmanship.com/posts/value-object-better-implementation/
        protected ValueObjectBase(TValue data) : base(data)
        {
        }
    }
}