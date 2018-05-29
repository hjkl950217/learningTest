using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareCK
{
    public interface IMiddleware
    {
        /// <summary>
        /// 下一个中间件
        /// </summary>
        /// <remarks>
        /// 在初始化时统一排序和赋值
        /// </remarks>
        IMiddleware Next { get; set; }

        /// <summary>
        /// 执行顺序
        /// </summary>
        int ExecuteOrder { get; }
    }
}
