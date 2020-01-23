using System.Collections.Generic;
using System.Linq;

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

        #region 内部逻辑

        public override bool EqualsCode(TValue value)
        {
            return Enumerable.SequenceEqual(
                first: this.GetEqualityComponents(this.Value),
                second: this.GetEqualityComponents(value));
        }

        public override int GetHashCodeCore()
        {
            //        return GetEqualityComponents()
            //.Aggregate(1, (current, obj) =>
            //{
            //    unchecked
            //    {
            //        return current * 23 + (obj?.GetHashCode() ?? 0);
            //    }
            //});

            //todo:待测试GetHashCode
            /*      1       2
             * 1    null    "abc"
             * 2    null    null
             * 3    "abc"   null
             * 4    null    null
             *
             *
             */

            return this.GetEqualityComponents(this.Value)
                  .Aggregate(1, (first, next) =>
                  {
                      //这里256这个数字是随便写的，是为了避免计算哈希值的逻辑有重复的
                      return (first * 256) ^ (next?.GetHashCode() ?? 0);
                  });
        }

        #endregion 内部逻辑

        #region 需要子类重写

        /// <summary>
        /// 由子类重写，获取参与相等比较的成员
        /// </summary>
        /// <returns></returns>
        protected abstract IEnumerable<object> GetEqualityComponents(TValue value);

        #endregion 需要子类重写
    }
}