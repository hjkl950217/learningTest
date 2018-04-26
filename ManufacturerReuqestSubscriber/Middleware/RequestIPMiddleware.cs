using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ManufacturerReuqestSubscriber.Middleware
{
    /// <summary>
    /// IP记录中间件
    /// </summary>
    public class RequestIPMiddleware
    {
        /// <summary>
        /// 下一个中间件委托
        /// </summary>
        private readonly RequestDelegate nextMiddleware;
        /// <summary>
        /// 日志记录器
        /// </summary>
        private readonly ILogger logger;

        public RequestIPMiddleware( RequestDelegate next , ILoggerFactory loggerFactory )
        {
            this.nextMiddleware = next ?? throw new ArgumentNullException( nameof( next ) );
            this.logger = loggerFactory.CreateLogger<RequestIPMiddleware>( );
        }

        /// <summary>
        /// 开始执行中间件逻辑
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke( HttpContext context )
        {
            //这个中间件就是为了记录IP

            //1.自己的操作
            string ipStr = context.Connection.RemoteIpAddress.ToString( );
            this.logger.LogInformation( "\r\nUser IP: " + ipStr + "\r\n");

            //2.调用下一个中间件
            await this.nextMiddleware.Invoke( context );

            //3.上面的代码执行后的后续工作
            if( context.Response.StatusCode == 204 )
            {

                string logStr = $"IP为:{ipStr}的客户端发送了一次无效查询请求";

                this.logger.LogWarning( LoggingEvents.GetRequest , logStr );
            }

            return;
        }

    }


}
