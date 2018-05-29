using System;

namespace MiddlewareCK
{
    /// <summary>
    /// 中间件类型
    /// </summary>
    public enum MiddlewareTypeEnum
    {
        /// <summary>
        /// 标识第一个中间件
        /// </summary>
        Start,

        /// <summary>
        /// 标识结尾中间件，只是用来完结，一般无实际逻辑意义
        /// </summary>
        End,

    }
}
