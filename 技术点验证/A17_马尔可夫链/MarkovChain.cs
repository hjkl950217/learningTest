using System.Collections.Generic;

namespace 技术点验证
{
    /// <summary>
    /// 马尔可夫链节点实体，一个对象代表一个关系
    /// <para>A->B 为一组, A->C 为另一组</para>
    /// </summary>
    public class MarkovChain
    {
        /// <summary>
        /// 当前节点的名字
        /// </summary>
        public string NodeName { get; set; }

        /// <summary>
        /// 后续节点
        /// </summary>
        public List<MarkovChain> NextNodeList { get; } = new List<MarkovChain>();

        /// <summary>
        /// 到下一个节点，出现的次数
        /// </summary>
        public int NextNodeNum { get => this.NextNodeList.Count; }

        /// <summary>
        /// 到下一个节点的概率
        /// </summary>
        public double NextNodeProbability { get => this.NextNodeNum == 0 ? 0 : 1 / (double)this.NextNodeNum; }

        /// <summary>
        /// 到下一个节点的概率(字符串版本)
        /// </summary>
        public string NextNodeProbabilityString { get => $"{this.NextNodeProbability.ToString("0.00")}%"; }
    }
}