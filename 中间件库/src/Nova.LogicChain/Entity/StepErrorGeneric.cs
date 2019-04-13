//namespace Nova.LogicChain.Entity
//{
//    /// <summary>
//    /// 业务验证中的元素
//    /// </summary>
//    public class StepError<TErrorEntity> : StepError
//        where TErrorEntity : class
//    {
//        /// <summary>
//        /// 自定义信息 类型固定为<typeparamref name="TErrorEntity"/>
//        /// </summary>
//        public override object CustomInfo
//        {
//            get => this.CustomInfoEntity;
//            set => this.CustomInfoEntity = value as TErrorEntity;
//        }

//        /// <summary>
//        /// 自定义信息(泛型)
//        /// </summary>
//        public TErrorEntity CustomInfoEntity { get; set; } = default;

//        /// <summary>
//        /// 内部错误。类型固定为<see cref="StepError{TErrorEntity}"/>
//        /// </summary>
//        public override StepError InnerError
//        {
//            get => this.InnerErrorGeneric;
//            set => this.InnerErrorGeneric = value as StepError<TErrorEntity>;
//        }

//        /// <summary>
//        /// 内部错误(泛型)
//        /// </summary>
//        public StepError<TErrorEntity> InnerErrorGeneric { get; set; } = default;
//    }
//}