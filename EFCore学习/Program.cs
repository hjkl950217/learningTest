using EFCore学习.Data;
using EFCore学习.LogicCode;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;

namespace EFCore学习
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
            Console.WriteLine("Hello World!");

            #region 模拟注册

            //配置
            KeyValuePair<string, string>[] testConfig = new KeyValuePair<string, string>[]
                {
               new KeyValuePair<string, string>("DefaultConnection",@"Application Name=Lynn;data source=wcmis218\sqlexpress;database=Lynn_Test;user id=sa;password=yhdckGTX007.;Timeout=30;connection lifetime=300; min pool size=2; max pool size=50")
                };

            IServiceCollection services = new ServiceCollection();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(testConfig)
                .Build();

            //模拟注册服务的方法
            services.AddDbContext<SchoolContext>(options =>
                options
                .UseLoggerFactory(Program.loggerFactory)
                .UseSqlServer(configuration.GetValue<string>("DefaultConnection"))
            );

            //模拟注册日志工厂
            services.AddSingleton<ILoggerFactory>(Program.loggerFactory);

            //模拟业务代码注册
            services.AddSingleton<TestCode>();

            var di = services.BuildServiceProvider();
            SchoolContext context = di.GetRequiredService<SchoolContext>();

            DbInitializer.Initalze(context);//这行是初始化数据的

            #endregion 模拟注册

            //模拟业务代码开始
            var testCode = di.GetRequiredService<TestCode>();
            testCode.Run();

        }
    }
}