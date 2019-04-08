using System;
using System.Collections.Generic;
using System.Linq;
using Verification.Core;

namespace 技术点验证
{
    public class A17_马尔科夫链 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A17_马尔可夫链链;

        /*
         * 用马尔可夫链来生成不同的路径
         *
         * 1.先从样本中找到每个节点到下个节点的概率(或是找出所有可能的路径)
         * 2.然后重组成新的、 不同的链路
         *
         * 原文：https://zhuanlan.zhihu.com/p/61028042
         */

        public void Start(string[] args)
        {
            Console.WriteLine("原始数据");
            foreach (var item in this.data)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================");
            Console.WriteLine();

            this.SplitData(this.data);

            Console.WriteLine("分析概率后的数据");
            var markovData = this.AnalyzeData(this.SplitData, this.CreateList, this.data);
            foreach (var item in markovData.OrderBy(t => t.Key))
            {
                Console.WriteLine($"key:{item}\t到下一节点的数量：{item.Value.NextNodeNum}\t概率：{item.Value.NextNodeProbabilityString}");
            }
            Console.WriteLine("======================");
            Console.WriteLine();
        }

        #region 字段区

        /// <summary>
        /// 原始数据
        /// </summary>
        private readonly string[] data = new string[]
        {
            "->",
            "1A -> 2F -> 3A -> 4F",
            "1E -> 2C -> 3A -> 4C"
        };

        /// <summary>
        /// 分割符
        /// </summary>
        private readonly string separator = "->";

        private static Func<MarkovChainNode> NodeFactory(string key)
        {
            return () =>
            {
                switch (key)
                {
                    case MarkovChainNode.StartNodeName: return MarkovChainNode.CreateStartNode();

                    case MarkovChainNode.EndNodeName: return MarkovChainNode.EndNode;
                    default: return new MarkovChainNode() { NodeName = key };
                }
            };
        }

        #endregion 字段区

        /// <summary>
        /// 创建初始集合，包含开始节点
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, MarkovChainNode> CreateList()
        {
            Dictionary<string, MarkovChainNode> result = new Dictionary<string, MarkovChainNode>();
            return result;
        }

        /// <summary>
        /// 分割数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns>
        /// 一条string[]代表处理好的样本
        /// </returns>
        private List<string[]> SplitData(string[] data)
        {
            List<string[]> result = new List<string[]>();

            foreach (var item in data)
            {
                if (item == null || item.Length == 0 || item.Trim() == this.separator)
                    continue;

                string[] tempArry = ($"{MarkovChainNode.StartNodeName}->{item}->{MarkovChainNode.EndNodeName}")
                    .Split(this.separator, StringSplitOptions.RemoveEmptyEntries)
                    .Where(t => !string.IsNullOrEmpty(t))//找出不为null的字段
                    .Select(t => t.Trim())
                    .ToArray();

                result.Add(tempArry);
            }

            return result;
        }

        /// <summary>
        /// 分析数据
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, MarkovChainNode> AnalyzeData(
            Func<string[], List<string[]>> splitFunc,
            Func<Dictionary<string, MarkovChainNode>> initialFactory,
            string[] sourceData)
        {
            Dictionary<string, MarkovChainNode> result = initialFactory();
            List<string[]> splitedData = splitFunc(sourceData);

            #region 遍历并处理

            foreach (var item in splitedData)//遍历每条数据
            {
                for (int i = 0 ; i < item.Length ; i++)//遍历每条数据中的节点
                {
                    //从结果区中拿到节点
                    var tempNode = result.GetOrAdd(item[i], NodeFactory(item[i]));

                    //添加节点 关联下一个节点
                    bool isEnd = i + 1 == item.Length;
                    if (!isEnd)
                    {
                        //如果不是最后一个节点，关联下一个节点
                        var nextNode = result.GetOrAdd(item[i + 1], NodeFactory(item[i + 1]));
                        tempNode.NextNodeList.Add(nextNode);
                    }

                    //最后一个节点是默认的end节点，所以只需要处理end节点之前的就好
                }
            }

            #endregion 遍历并处理

            return result;
        }
    }
}