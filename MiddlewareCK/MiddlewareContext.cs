using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareCK
{
    /// <summary>
    /// 中间件执行逻辑中的上下文
    /// </summary>
    /// <typeparam name="TResult">执行完成后要从上下文中取得的结果</typeparam>
    public interface MiddlewareContext<TResult>
    {

        /// <summary>
        /// 获取执行结果
        /// </summary>
        /// <returns></returns>
        TResult GetResult();

        /// <summary>
        /// 获取执行结果
        /// </summary>
        /// <returns></returns>
        Task<TResult> GetResultAsync();
    }
}
