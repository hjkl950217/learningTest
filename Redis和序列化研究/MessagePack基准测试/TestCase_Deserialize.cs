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
            MsgSerializer.InitializeMsgPackSerializer();
            var testIntDataT = TestHelper.GetIntTestData(this.TestTotal);
            var testStringDataT = TestHelper.GetIntTestData2(this.TestTotal);
            var testNonDataT = TestHelper.GetIntTestData3(this.TestTotal);
            var testDefaultDataT = TestHelper.GetIntTestData3(this.TestTotal);
            var testJsonDataT = TestHelper.GetIntTestData3(this.TestTotal);

            this.testIntData = MsgSerializer.Serialize(testIntDataT);
            this.testStringData = MsgSerializer.Serialize(testStringDataT);
            this.testNonData = MsgSerializer.Serialize(testNonDataT);
            this.testDefaultData = MsgSerializer.SerializeDefault(testDefaultDataT);
            this.testJsonData = Encoding.UTF8.GetBytes(MsgSerializer.SerializeJson(testJsonDataT));
        }

        [Benchmark]
        public List<TestEntity_Int> TestIntDeserialize()
        {
            return MsgSerializer.Deserialize<List<TestEntity_Int>>(this.testIntData);
        }

        [Benchmark]
        public List<TestEntity_String> TestStringDeserialize()
        {
            return MsgSerializer.Deserialize<List<TestEntity_String>>(this.testStringData);
        }

        [Benchmark]
        public List<TestEntity_Non> TestNonDeserialize()
        {
            return MsgSerializer.Deserialize<List<TestEntity_Non>>(this.testNonData);
        }

        [Benchmark]
        public List<TestEntity_Non> TestDefaultDeserialize()
        {
            return MsgSerializer.DeserializeDefault<List<TestEntity_Non>>(this.testDefaultData);
        }

        [Benchmark]
        public List<TestEntity_Non> TestJsonDeserialize()
        {
            return MsgSerializer
                .DeserializeJson<List<TestEntity_Non>>(Encoding.UTF8.GetString(this.testJsonData));
        }
    }
}