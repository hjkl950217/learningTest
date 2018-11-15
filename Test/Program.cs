using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using Test.DB;

namespace Test
{
    internal class Program
    {
        public static readonly ILoggerFactory loggerFactory = new LoggerFactory(new[]
        {
            new ConsoleLoggerProvider(
                (category,level)=>
                {
                    return (level==LogLevel.Information)
                    ||(level==LogLevel.Warning)
                    ||(level==LogLevel.Error);
                },
                true)
        });

        private static void Main(string[] args)
        {
            /*
             * 教程地址：
             * https://docs.microsoft.com/zh-cn/aspnet/core/data/ef-rp/?view=aspnetcore-2.1
             * 
             * 只能参考，他的教程更像是说明文档
             * 
             */


            Console.WriteLine("Hello World!");

            #region 模拟注册

            //配置
            KeyValuePair<string, string>[] testConfig = new KeyValuePair<string, string>[]
                {
                    new KeyValuePair<string, string>(
                        "JiraConnection",
                        @"data source=10.16.89.40;database=jira_hackathon;user id=hackathonDbo;password=hackathonDbo;"),
                    new KeyValuePair<string, string>(
                        "ConfluenceConnection",
                        @"data source=10.16.89.40;database=confluence_hackathon;user id=hackathonDbo;password=hackathonDbo;")
                };

            IServiceCollection services = new ServiceCollection();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(testConfig)
                .Build();

            //模拟注册服务的方法
            services.AddDbContext<JiraContext>(options =>
                options
                .UseLoggerFactory(Program.loggerFactory)
                .UseSqlServer(configuration.GetValue<string>("JiraConnection"))
            );
            services.AddDbContext<ConfluenceContext>(options =>
            options
               .UseLoggerFactory(Program.loggerFactory)
               .UseSqlServer(configuration.GetValue<string>("ConfluenceConnection"))
           );

            //模拟注册日志工厂
            services.AddSingleton<ILoggerFactory>(Program.loggerFactory);

            //模拟业务代码注册
            services.AddSingleton<ServiceCode>();

            var di = services.BuildServiceProvider();
            JiraContext context = di.GetRequiredService<JiraContext>();

           // DbInitializer.Initalze(context);//这行是初始化数据的

            #endregion 模拟注册

            //模拟业务代码开始
            var testCode = di.GetRequiredService<ServiceCode>();
            testCode.Run();

        }
    }
}