using System;
using System.Linq.Expressions;
using System.Text;

namespace 语法验证与学习
{
    public abstract class BaseTranslator
    {
        /// <summary>
        /// 代表内容
        /// </summary>
        protected readonly StringBuilder content;

        /// <summary>
        /// 换行符
        /// </summary>
        protected readonly string LinaBreakSymbol;

        /// <summary>
        /// 制表符
        /// </summary>
        protected readonly string TablSymbol;

        /// <summary>
        /// 当前翻译器需要翻译的节点
        /// </summary>
        protected readonly Expression node;

        public ExpressionType NodeType => this.node.NodeType;

        protected BaseTranslator(
            Expression node, 
            string strPrefix = null, 
            StringBuilder content = null)
        {
            this.content = content ?? new StringBuilder();
            this.LinaBreakSymbol = @"\r\n";
            this.TablSymbol = strPrefix ?? @"\t";
            this.node = node;
        }

        ///// <summary>
        ///// 替代Console.WriteLine 因为{strPrefix}每次都要写
        ///// </summary>
        ///// <param name="value"></param>
        ///// <param name="strPrefix"></param>
        ///// <returns></returns>
        //protected virtual StringBuilder WriteLine(string value, string strPrefix = null)
        //{
        //    this.content.AppendLine($"{strPrefix}{value}");
        //    return this.content;
        //}

        //protected virtual StringBuilder Write(string value, string strPrefix = null)
        //{
        //    this.content.Append($"{strPrefix}{value}");
        //    return this.content;
        //}

        /// <summary>
        /// 创建翻译者
        /// </summary>
        /// <param name="rootNode"></param>
        /// <param name="strPrefix">翻译时的前缀,用来显示成树形结构</param>
        /// <returns></returns>
        public BaseTranslator CreateTranslator(Expression rootNode, string strPrefix = null, StringBuilder content = null)
        {
            //处理这些变量的引用，因为是递归调用此方法，尽量避免额外的内存分配
            //这样处理后，子类在调用时就可以一直把最开始的这些变量引用传递进去
            strPrefix = strPrefix ?? this.TablSymbol;
            if (strPrefix != null)
            {
                strPrefix = $"{strPrefix}{this.TablSymbol}";
            }
            content = content ?? this.content;

            switch (rootNode.NodeType)
            {
                case ExpressionType.Add:
                    return new BinaryTranslator((BinaryExpression)rootNode, strPrefix, content);

                default:
                    this.content.AppendLine($"遇到了不支持的节点类型:{rootNode.NodeType}");
                    return default;
            }

            throw new NotImplementedException();
        }
    }

    public class BinaryTranslator : BaseTranslator
    {
        public BinaryTranslator(
            BinaryExpression node,
            string strPrefix = null,
            StringBuilder content = null
            ) 
            : base(node, strPrefix, content)
        {
        }



    }
}