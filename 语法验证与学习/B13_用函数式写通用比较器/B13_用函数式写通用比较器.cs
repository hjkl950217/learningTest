using AutoFixture;
using System;
using System.Linq;
using Verification.Core;

namespace 语法验证与学习
{
    public class B13_用函数式写通用比较器 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B13_用函数式写通用比较器;

        private readonly Fixture fixture = new Fixture();
        private int count = 3;

        public void Start(string[] args)
        {
            // this.ShowRepeat();

            this.Show_HigherOrderFunction();
        }

        #region 造数据

        public TwoValueEntity[] GetRepeat()
        {
            TwoValueEntity[] result = new TwoValueEntity[this.count];

            int id = this.fixture.Create<int>();
            string name = this.fixture.Create<string>();
            for (int i = 0 ; i < result.Length ; i++)
            {
                result[i] = new TwoValueEntity()
                {
                    ID = id,
                    Name = name
                };
            }

            return result;
        }

        public TwoValueEntity[] GetIDRepeat()
        {
            TwoValueEntity[] result = new TwoValueEntity[this.count];

            int id = this.fixture.Create<int>();
            for (int i = 0 ; i < result.Length ; i++)
            {
                result[i] = new TwoValueEntity()
                {
                    ID = id,
                    Name = this.fixture.Create<string>()
                };
            }

            return result;
        }

        public TwoValueEntity[] GetNameRepeat()
        {
            TwoValueEntity[] result = new TwoValueEntity[this.count];

            string name = this.fixture.Create<string>();
            for (int i = 0 ; i < result.Length ; i++)
            {
                result[i] = new TwoValueEntity()
                {
                    ID = this.fixture.Create<int>(),
                    Name = name
                };
            }

            return result;
        }

        public TwoValueEntity[] GetNoRepeat()
        {
            TwoValueEntity[] result = new TwoValueEntity[this.count];

            string name = this.fixture.Create<string>();
            for (int i = 0 ; i < result.Length ; i++)
            {
                result[i] = this.fixture.Create<TwoValueEntity>();
            }

            return result;
        }

        #endregion 造数据

        #region 全重复

        public void ShowRepeat()
        {
            System.Console.WriteLine("===演示全重复的情况===");
            TwoValueEntity[] repeatObjs = this.GetRepeat();

            var comparer = new TwoValueEntityComparer();
            var repeatObjHashCodes = repeatObjs.Distinct(comparer).Select(t => t.GetHashCode());
            var repeatObjHashCodes2 = repeatObjs.Distinct().Select(t => t.GetHashCode());

            System.Console.WriteLine("用比较器接口: " + repeatObjHashCodes.ToJson());
            Console.WriteLine("---------");
            System.Console.WriteLine("用默认行为: " + repeatObjHashCodes2.ToJson());

            Func<Func<TwoValueEntity, string>, Func<TwoValueEntity, int>> ShowValue222222 = getValue => value => getValue(value).GetHashCode();

            System.Console.WriteLine("===演示全重复的情况===");
        }

        public void Show_HigherOrderFunction()
        {
            Console.WriteLine("输出实体中Name属性的哈希值");

            TwoValueEntity entity = fixture.Create<TwoValueEntity>();
            Console.WriteLine("实体的值:");
            Console.WriteLine(entity.ToJson());

            Console.WriteLine("POP的结果:");
            Console.WriteLine(entity.Name.GetHashCode());

            //取得哈希值
            Func<Func<TwoValueEntity, string>, Func<TwoValueEntity, int>> getHashCode = getValue => entity => getValue(entity).GetHashCode();

            //输出到控制台
            Func<Func<TwoValueEntity, int>, Action<TwoValueEntity>> showHahCode = getHCode => entity => Console.WriteLine(getHCode(entity));

            Console.WriteLine("FP的结果:");
            showHahCode(getHashCode(t => t.Name))(entity);
        }

        #endregion 全重复
    }
}