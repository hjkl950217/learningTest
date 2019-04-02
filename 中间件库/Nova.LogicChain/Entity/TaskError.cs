using System;
using System.Collections.Generic;

namespace Nova.LogicChain.Entity
{
    /// <summary>
    /// 业务验证中的元素
    /// </summary>
    public class TaskError
    {
        /// <summary>
        /// 自定义信息
        /// </summary>
		public object CustomInfo { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
		public string ErrorMessage { get; set; }

        /// <summary>
        /// 错误步骤
        /// </summary>
        public string ErrorStep { get; set; }

        /// <summary>
        /// 具体异常数据
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// 内部错误
        /// </summary>
        public List<TaskError> InnerErrors { get; set; }
    }
}