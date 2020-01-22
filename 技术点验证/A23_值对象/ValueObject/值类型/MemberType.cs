namespace 技术点验证
{
    public class MemberType : ValueBase<MemberTypeEnum>
    {
        private MemberType(MemberTypeEnum data) : base(data)
        {
        }

        public static MemberType Create(int idCardNo)
        {
            /*
             * 演示需要从 一种数据 转换成另一种数据时如何使用 ValueObject
             *
             * 假定 id  在 1 ~1000 为老师
             *          大于1000 为学生
             *
             */

            return idCardNo switch
            {
                int id when id < 0 => throw new System.ArgumentException(errorMsg),
                int id when id < 1001 => new MemberType(MemberTypeEnum.Teacher),
                _ => new MemberType(MemberTypeEnum.Student),
            };

            //模式匹配版本
            //switch (idCard)
            //{
            //    case int id when id < 0:
            //        throw new System.ArgumentException(errorMsg);

            //    case int id when id < 1000:
            //        return new MemberTypeType(MemberTypeEnum.Teacher);

            //    default:
            //        return new MemberTypeType(MemberTypeEnum.Student);
            //}
        }

        public static MemberType Create(IdCardNo idCardNo) => Create((int)idCardNo);

        public override bool BizCheckValue() => true;

        public const string errorMsg = "idCard must be greater than 0";

        public override string ErrorMsgForCheckValue(MemberTypeEnum memberTypeEnum) => errorMsg;
    }
}