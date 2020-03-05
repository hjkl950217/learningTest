using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace 技术点验证._A15_分割字符串的基准测试_
{
    [SimpleJob]
    [ProcessCount(2)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn, MemoryDiagnoser]
    public class SubstringTest
    {
#pragma warning disable S1450
        private readonly char[] symbols = new char[] { ';', '-', '*', '#', '!' };
        private string?[]? TestList;
#pragma warning restore S1450

#pragma warning disable S1104 // Fields should not have public accessibility

        [Params(10 * 1000, 30 * 1000)]
        public int DataCount;

#pragma warning restore S1104 // Fields should not have public accessibility

        [GlobalSetup]
        public void SetUp()
        {
            this.TestList = this.GetTestDataList();
        }

        private string[] GetTestDataList()
        {
            string[] result = new string[this.DataCount];
            for (int i = 0 ; i < this.DataCount ; i++)
            {
                int lenth = TestHelper.random.Next(10);
                char[] tempChars = new char[lenth];

                //随机一个字符串
                for (int j = 0 ; j < lenth ; j++)
                {
                    tempChars[j] = TestHelper.GetRandomChar();

                    if (j % 2 == 0)
                    {
                        tempChars[j] = TestHelper.GetRandomChar();
                    }
                    else
                    {
                        tempChars[j] = this.symbols[TestHelper.random.Next(this.symbols.Length)];
                    }
                }

                //把随机的字符串添加到返回结果中
                result[i] = new string(tempChars);
            }

            return result;
        }

        [Benchmark(Baseline = true)]
        public void MethodA_Master()
        {
            foreach (var item in this.TestList)
            {
                this.MethodA(item, this.symbols);
            }
        }

        [Benchmark]
        public void MethodB_Master()
        {
            foreach (var item in this.TestList)
            {
                this.MethodB(item, this.symbols);
            }
        }

        public string MethodA(string source, params char[] symbols)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            else if (source.Length == 0)
            {
                return source;
            }

            char[] chars = source.ToCharArray();

            bool isExtra = symbols.Any(t => chars[chars.Length - 1] == t);
            if (isExtra == true)
            {
                return new string(chars.Take(chars.Length - 1).ToArray());
            }
            else
            {
                return source;
            }
        }

        public string MethodB(string source, params char[] symbols)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            else if (source.Length == 0)
            {
                return source;
            }

            var chars = source.AsSpan();
            bool isExtra = false;
            foreach (var item in symbols)
            {
                isExtra = chars[source.Length - 1] == item;
                if (isExtra == true) break;
            }
            if (isExtra == true)
            {
                return chars.Slice(0, source.Length - 1).ToString();
            }
            else
            {
                return source;
            }
        }
    }
}