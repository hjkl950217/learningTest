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

            //Console.WriteLine("分析概率后的数据");
            //var markovData = this.FindAllPath(this.data, this.separator);
            //foreach (var item in markovData.OrderBy(t => t.NodeName))
            //{
            //    Console.WriteLine($"key:{item}\t到下一节点的数量：{item.NextNodeNum}\t概率：{item.NextNodeProbabilityString}");
            //}
            //Console.WriteLine("======================");
            //Console.WriteLine();
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

        private static readonly string startNodeName = "Start";
        private static readonly string endNodeName = "End";

        private static readonly MarkovChain startNode = new MarkovChain()
        {
            NodeName = startNodeName
        };
        private static readonly MarkovChain endNode = new MarkovChain()
        {
            NodeName = endNodeName
        };

        private static Func<MarkovChain> valueFactory(string key)
        {
            return () => new MarkovChain() { NodeName = key };
        }

        #endregion 字段区

        /*
         * todo:A17_马尔科夫链
         * 分割，然后创建默认的集合
         * 
         * 然后用递归+动态规划
         * 
         * 
         * 递归用来遍历树，用动态规划记录数据
         * 
         * 
         */



        /// <summary>
        /// 创建初始集合，包含开始节点
        /// </summary>
        /// <returns></returns>
        private List<MarkovChain> CreateList()
        {
            List<MarkovChain> result = new List<MarkovChain>();
            result.Add(new MarkovChain() { NodeName = startNodeName });//添加默认节点

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

                string[] tempArry = ($"{startNodeName}->{item}->{endNodeName}")
                    .Split(this.separator, StringSplitOptions.RemoveEmptyEntries)
                    .Where(t => !string.IsNullOrEmpty(t))//找出不为null的字段
                    .Select(t => t.Trim())
                    .ToArray();

                result.Add(tempArry);
            }

            return result;
        }
    }
}