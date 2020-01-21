namespace 技术点验证
{
    public class IdCard : ValueObject<string>
    {
        public IdCard(string data) : base(data)
        {
        }

        public override bool BizCheckValue()
        {
            return base.Value.Length == 18
                  && base.Value[17] == 'X';
        }

        public override string ErrorMsgForCheckValue()
        {
            return "IdCard 必须为18位,若后一位不是数字，则必须为X";
        }
    }

    public class Age : ValueObject<int>
    {
        public Age(int data) : base(data)
        {
        }

        public override bool BizCheckValue()
        {
            return base.Value > 17;
        }

        public override string ErrorMsgForCheckValue()
        {
            return "年龄必须大于18岁";
        }
    }
}