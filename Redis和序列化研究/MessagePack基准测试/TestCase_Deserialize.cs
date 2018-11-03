using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Text;

namespace Redis和序列化研究
{
    [CoreJob]
    [ProcessCount(5)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn, MemoryDiagnoser]
    public class TestCase_Deserialize
    {
        private byte[] testIntData;
        private byte[] testStringData;
        private byte[] testNonData;
        private byte[] testDefaultData;
        private byte[] testJsonData;

        [Params(1 * 100, 1000, 5000, 10000)]
        public int TestTotal;

        [GlobalSetup]
        public void SetUp()
        {
            Serializable.StartupSerializable();
            var testIntDataT = TestHelper.GetIntTestData(this.TestTotal);
            var testStringDataT = TestHelper.GetIntTestData2(this.TestTotal);
            var testNonDataT = TestHelper.GetIntTestData3(this.TestTotal);
            var testDefaultDataT = TestHelper.GetIntTestData3(this.TestTotal);
            var testJsonDataT = TestHelper.GetIntTestData3(this.TestTotal);

            this.testIntData = Serializable.Serialize(testIntDataT);
            this.testStringData = Serializable.Serialize(testStringDataT);
            this.testNonData = Serializable.Serialize(testNonDataT);
            this.testDefaultData = Serializable.SerializeDefault(testDefaultDataT);
            this.testJsonData = Encoding.UTF8.GetBytes(Serializable.SerializeJson(testJsonDataT));
        }

        [Benchmark]
        public List<TestEntity_Int> TestIntDeserialize()
        {
            return Serializable.Deserialize<List<TestEntity_Int>>(this.testIntData);
        }

        [Benchmark]
        public List<TestEntity_String> TestStringDeserialize()
        {
            return Serializable.Deserialize<List<TestEntity_String>>(this.testStringData);
        }

        [Benchmark]
        public List<TestEntity_Non> TestNonDeserialize()
        {
            return Serializable.Deserialize<List<TestEntity_Non>>(this.testNonData);
        }

        [Benchmark]
        public List<TestEntity_Non> TestDefaultDeserialize()
        {
            return Serializable.DeserializeDefault<List<TestEntity_Non>>(this.testDefaultData);
        }

        [Benchmark]
        public List<TestEntity_Non> TestJsonDeserialize()
        {
            return Serializable
                .DeserializeJson<List<TestEntity_Non>>(Encoding.UTF8.GetString(this.testJsonData));
        }
    }
}