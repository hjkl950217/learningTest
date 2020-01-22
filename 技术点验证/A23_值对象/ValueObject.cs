using System;
using Verification.Core;

namespace 技术点验证
{
    /// <summary>
    /// 值对象基类<para></para>
    /// 可保证数据不能为null，数据正确(需重写<see cref="BizCheckValue"/>方法以完成业务规则检测)<para></para>
    /// 使用时可以当普通数据使用，如: int a=new Age(50)
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public abstract class ValueObject<TValue> : IValueObject<TValue>
    {
        //微软关于值对象的资料:https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects
        //它是针对一个对象的。但目前我们只需要保证单个数据值是值对象即可，还不上升到更高的层级

        public TValue Value { get; }

        #region 内部逻辑

        protected ValueObject(TValue data)
        {
            this.Value = data;

            if (this.IsNulReference(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            var checkObj = this.Check();
            if (!checkObj.checkResult)
            {
                throw new ArgumentException(checkObj.errorObj.ErrorMessage, nameof(data));
            }
        }

        /// <summary>
        /// 检查空引用。值类型与非空则返回false，引用类型为空时返回true
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private bool IsNulReference(TValue data)
        {
            if (typeof(TValue).IsValueType)
            {
                return false;
            }
            else
            {
                return data == null;
            }
        }

        /// <summary>
        /// 检查数据<para></para>
        /// 检查通过返回true，否则返回false+错误对象
        /// </summary>
        /// <returns></returns>
        public virtual (bool checkResult, BizError errorObj) Check()
        {
            if (this.BizCheckValue())
            {
                return (
                    true,
                    new BizError());
            }
            else
            {
                return (false, this.GetBizError());
            }
        }

        public override bool Equals(object obj)
        {
            var obj2 = obj as IValueObject<TValue>;
            if (obj2 != null)
            {
                return this.Value.Equals(obj2.Value);
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        #endregion 内部逻辑

        #region 子类重写

        /// <summary>
        /// 由子类重写，指示如何进行业务检查。true为检查通过，否则为false
        /// </summary>
        /// <returns></returns>
        public abstract bool BizCheckValue();

        /// <summary>
        /// 由子类重写，指示当业务检查失败时，异常中的错误信息。
        /// </summary>
        /// <param name="value">发生错误的值</param>
        /// <returns></returns>
        public virtual string ErrorMsgForCheckValue(TValue value) => $"Check {this.GetType().Name} value error. now value:{value.ToString()}";

        #endregion 子类重写

        #region 子类可用的方法

        /// <summary>
        /// 获取一个<see cref="BizError"/>对象
        /// </summary>
        /// <returns></returns>
        protected virtual BizError GetBizError()
        {
            return new BizError()
            {
                ErrorCode = "0OO0",
                CustomObject = this,
                ErrorMessage = this.ErrorMsgForCheckValue(this.Value)
            };
        }

        #endregion 子类可用的方法

        #region 符号重载

        //== !=必须调用Equals方法。因为 vo1==null 这种也是调用一个等号运算符，导致死循环

        public static bool operator ==(ValueObject<TValue> vo1, ValueObject<TValue> vo2)
        {
            return object.Equals(vo1, vo2);//具体比较逻辑由Equals完成
        }

        public static bool operator !=(ValueObject<TValue> vo1, ValueObject<TValue> vo2)
        {
            return !object.Equals(vo1, vo2);// 具体比较逻辑由Equals完成
        }

        #region 隐式和显式转换

        /// <summary>
        /// 隐式转换  <![CDATA[ValueObject<T, TValue>->TValue   eg: TValue a=new ValueObject<TValue>(xxx)]]>
        /// </summary>
        /// <param name="valueObject"></param>
        public static implicit operator TValue(ValueObject<TValue> valueObject)
        {
            return valueObject.Value;
        }

        /*
         * 显式转换在这个基础类里没办法写，原因：
         *  TValue b = (TValue)(new ValueObject<TValue>(xxx)); 这种代码在编译时 (TValue)这个强转的就被编译器拿掉了。
         *
         * TValue b = (double)(new ValueObject<TValue>(xxx)); 而这种强转，也不可能在基础类里把所有的都 写进去
         *
         */

        #endregion 隐式和显式转换

        #endregion 符号重载
    }
}