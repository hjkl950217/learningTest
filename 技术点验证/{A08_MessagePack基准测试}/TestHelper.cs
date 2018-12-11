using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 技术点验证
{
    public static class TestHelper
    {
        //public static List<TestEntity> GetIntTestData<T>(int totaol)
        //    where T : TestEntity, new()
        //{
        //    List<TestEntity> testData = new List<TestEntity>();
        //    Random random = new Random(totaol);

        //    byte[] tempByte = new byte[random.Next(100)];
        //    random.NextBytes(tempByte);
        //    string testStr = UTF8Encoding.UTF8.GetString(tempByte);
        //    TestEnum[] testEnums = new TestEnum[3] { TestEnum.Open, TestEnum.Close, TestEnum.All };

        //    for (int i = 0 ; i < totaol ; i++)
        //    {
        //        T temp = new T()
        //        {
        //            Integr = 10,
        //            Double = 20.22,
        //            Decimal = 300.333M,
        //            Boolen = (totaol % 2) == 0,
        //            Name = testStr,
        //            TestEnum = testEnums[random.Next(0, 3)],
        //            TestColor = Color.FromArgb(random.Next(0, 256)),
        //            IntList = new List<int>() { 50, 100 },
        //            DoubleList = new List<double> { 50.50, 100.001 },
        //            StringArry = new string[] { testStr },
        //            DicList = new Dictionary<int, string>() { { 20, testStr } },
        //            DynamicObj = new List<object>() { new object() }
        //        };

        //        testData.Add(temp);
        //    }

        //    return testData;
        //}

        public static List<TestEntity_Int> GetIntTestData(int totaol)
        {
            List<TestEntity_Int> testData = new List<TestEntity_Int>();
            Random random = new Random(totaol);

            byte[] tempByte = new byte[random.Next(100)];
            random.NextBytes(tempByte);
            string testStr = UTF8Encoding.UTF8.GetString(tempByte);
            TestEnum[] testEnums = new TestEnum[3] { TestEnum.Open, TestEnum.Close, TestEnum.All };

            for (int i = 0 ; i < totaol ; i++)
            {
                TestEntity_Int temp = new TestEntity_Int()
                {
                    Integr = 10,
                    Double = 20.22,
                    Decimal = 300.333M,
                    Boolen = (totaol % 2) == 0,
                    Name = testStr,
                    TestEnum = testEnums[random.Next(0, 3)],
                    TestColor = Color.FromArgb(random.Next(0, 256)),
                    IntList = new List<int>() { 50, 100 },
                    DoubleList = new List<double> { 50.50, 100.001 },
                    StringArry = new string[] { testStr },
                    DicList = new Dictionary<int, string>() { { 20, testStr } },
                    DynamicObj = new List<object>() { new object() }
                };

                testData.Add(temp);
            }

            return testData;
        }

        public static List<TestEntity_String> GetIntTestData2(int totaol)
        {
            List<TestEntity_String> testData = new List<TestEntity_String>();
            Random random = new Random(totaol);

            byte[] tempByte = new byte[random.Next(100)];
            random.NextBytes(tempByte);
            string testStr = UTF8Encoding.UTF8.GetString(tempByte);
            TestEnum[] testEnums = new TestEnum[3] { TestEnum.Open, TestEnum.Close, TestEnum.All };

            for (int i = 0 ; i < totaol ; i++)
            {
                TestEntity_String temp = new TestEntity_String()
                {
                    Integr = 10,
                    Double = 20.22,
                    Decimal = 300.333M,
                    Boolen = (totaol % 2) == 0,
                    Name = testStr,
                    TestEnum = testEnums[random.Next(0, 3)],
                    TestColor = Color.FromArgb(random.Next(0, 256)),
                    IntList = new List<int>() { 50, 100 },
                    DoubleList = new List<double> { 50.50, 100.001 },
                    StringArry = new string[] { testStr },
                    DicList = new Dictionary<int, string>() { { 20, testStr } },
                    DynamicObj = new List<object>() { new object() }
                };

                testData.Add(temp);
            }

            return testData;
        }

        public static List<TestEntity_Non> GetIntTestData3(int totaol)
        {
            List<TestEntity_Non> testData = new List<TestEntity_Non>();
            Random random = new Random(totaol);

            byte[] tempByte = new byte[random.Next(100)];
            random.NextBytes(tempByte);
            string testStr = UTF8Encoding.UTF8.GetString(tempByte);
            TestEnum[] testEnums = new TestEnum[3] { TestEnum.Open, TestEnum.Close, TestEnum.All };

            for (int i = 0 ; i < totaol ; i++)
            {
                TestEntity_Non temp = new TestEntity_Non()
                {
                    Integr = 10,
                    Double = 20.22,
                    Decimal = 300.333M,
                    Boolen = (totaol % 2) == 0,
                    Name = testStr,
                    TestEnum = testEnums[random.Next(0, 3)],
                    TestColor = Color.FromArgb(random.Next(0, 256)),
                    IntList = new List<int>() { 50, 100 },
                    DoubleList = new List<double> { 50.50, 100.001 },
                    StringArry = new string[] { testStr },
                    DicList = new Dictionary<int, string>() { { 20, testStr } },
                    DynamicObj = new List<object>() { new object() }
                };

                testData.Add(temp);
            }

            return testData;
        }
    }
}