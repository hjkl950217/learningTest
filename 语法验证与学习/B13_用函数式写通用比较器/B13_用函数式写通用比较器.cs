using AutoFixture;
using System;
using Verification.Core;

namespace 语法验证与学习
{
    public class B13_用函数式写通用比较器 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.B13_用函数式写通用比较器;

        private readonly Fixture fixture = new Fixture();
        private int count = 2;

        public void Start(string[] args)
        {
            this.ShowTwoValueComparerTest();

            //this.Show_HigherOrderFunction();
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

        public void ShowTwoValueComparerTest()
        {
            int count = this.count;//比较器测试只要2个数据
            this.count = 2;
            System.Console.WriteLine("===演示比较器测试结果===");

            Console.WriteLine("==演示1 全重复==");
            TwoValueEntity[] repeatObjs = this.GetRepeat();
            this.TwoValueComparerEqualTest("a", 1, "a", 1, true);

            System.Console.WriteLine("===演示比较器测试结果===");
            this.count = count;//还原
        }

        private TwoValueEntityComparer twoValueEntityComparer = new TwoValueEntityComparer();

        public void TwoValueComparerEqualTest(string name1, int id1, string name2, int id2, bool expected)
        {
            TwoValueEntity entity1 = new TwoValueEntity() { Name = name1, ID = id1 };
            TwoValueEntity entity2 = new TwoValueEntity() { Name = name2, ID = id2 };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--测试Equal--");
            Console.WriteLine($"测试数据1:{nameof(TwoValueEntity.Name)}:{entity1.Name}\t\t{nameof(TwoValueEntity.ID)}:{entity1.ID}");
            Console.WriteLine($"测试数据2:{nameof(TwoValueEntity.Name)}:{entity2.Name}\t\t{nameof(TwoValueEntity.ID)}:{entity2.ID}");
            Console.WriteLine($"预期结果:{expected}");
            bool actual = twoValueEntityComparer.Equals(entity1, entity2);
            Console.WriteLine($"实际结果:{actual}");
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