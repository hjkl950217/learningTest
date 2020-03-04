using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace 技术点验证
{
    //[SimpleJob(RuntimeMoniker.NetCoreApp22)]
    [SimpleJob]
    [ProcessCount(5)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn, MemoryDiagnoser]
    [InProcess]
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
            MsgSerializer.InitializeMsgPackSerializer();
            this.testIntData = TestHelper.GetIntTestData(this.TestTotal);
            this.testStringData = TestHelper.GetIntTestData2(this.TestTotal);
            this.testNonData = TestHelper.GetIntTestData3(this.TestTotal);
        }

        [Benchmark]
        public byte[] TestIntSerialize()
        {
            return MsgSerializer.Serialize(this.testIntData);
        }

        [Benchmark]
        public byte[] TestStringSerialize()
        {
            return MsgSerializer.Serialize(this.testStringData);
        }

        [Benchmark]
        public byte[] TestNonSerialize()
        {
            return MsgSerializer.SerializeDefault(this.testNonData);
        }

        [Benchmark]
        public byte[] TestDefaultSerialize()
        {
            return MsgSerializer.SerializeDefault(this.testNonData);
        }

        [Benchmark]
        public byte[] TestJsonSerialize()
        {
            return Encoding.UTF8.GetBytes(MsgSerializer.SerializeJson(this.testNonData));
        }
    }
}