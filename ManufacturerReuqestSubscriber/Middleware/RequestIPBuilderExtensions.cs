using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManufacturerReuqestSubscriber.Middleware;

namespace Microsoft.AspNetCore.Builder
{
    public static class RequestIPBuilderExtensions
    {
        /// <summary>
        /// 注册RequestIP中间件
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseRequestIP(this IApplicationBuilder app )
        {
            return app.UseMiddleware<RequestIPMiddleware>( );
        }

    }


}
