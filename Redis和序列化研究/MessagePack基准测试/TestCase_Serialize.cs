using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Text;

namespace Redis和序列化研究
{
    [ CoreJob]
    [ProcessCount(5)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn, MemoryDiagnoser]
    public class TestCase_Serialize
    {
        private List<TestEntity_Int> testIntData;
        private List<TestEntity_String> testStringData;
        private List<TestEntity_Non> testNonData;

        [Params(1 * 100, 1000, 5000, 10000)]
        public int TestTotal;

        [GlobalSetup]
        public void SetUp()
        {
            Serializable.StartupSerializable();
            this.testIntData = TestHelper.GetIntTestData(this.TestTotal);
            this.testStringData = TestHelper.GetIntTestData2(this.TestTotal);
            this.testNonData = TestHelper.GetIntTestData3(this.TestTotal);
        }

        [Benchmark]
        public byte[] TestIntSerialize()
        {
            return Serializable.Serialize(this.testIntData);
        }

        [Benchmark]
        public byte[] TestStringSerialize()
        {
            return Serializable.Serialize(this.testStringData);
        }

        [Benchmark]
        public byte[] TestNonSerialize()
        {
            return Serializable.SerializeDefault(this.testNonData);
        }

        [Benchmark]
        public byte[] TestDefaultSerialize()
        {
            return Serializable.SerializeDefault(this.testNonData);
        }

        [Benchmark]
        public byte[] TestJsonSerialize()
        {
            return Encoding.UTF8.GetBytes(Serializable.SerializeJson(this.testNonData));
        }
    }
}