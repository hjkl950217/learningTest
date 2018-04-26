using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ManufacturerReuqestSubscriber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder( args )
            //指定Kestrel作为Web主机使用的服务器。
            .UseKestrel( )
            //指定Web主机使用的内容根目录。
            .UseContentRoot( Directory.GetCurrentDirectory( ) )
            //按环境加载应用配置文件
            .ConfigureAppConfiguration( ( hostingContext , config ) =>
            {
                var env = hostingContext.HostingEnvironment;
                config.AddJsonFile( "appsettings.json" , optional: false , reloadOnChange: true )
                      .AddJsonFile( $"appsettings.{env.EnvironmentName}.json" , optional: true , reloadOnChange: true );
                config.AddEnvironmentVariables( );
            } )
            //启动时-日志配置
            .ConfigureLogging( ( hostingContext , logging ) =>
            {
                logging.AddConfiguration( hostingContext.Configuration.GetSection( "Logging" ) );
                logging.AddConsole( );
                logging.AddDebug( );
            } )
            //指定Web主机使用的启动类型
            .UseStartup<Startup>( )
            //指定web主机绑定的地址与端口
            .UseUrls("http://*:8048")
            //构建一个web主机
            .Build( );

        //WebHost.CreateDefaultBuilder(args)
        //    .UseStartup<Startup>()
        //    .Build();
    }
}
