using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace 技术点验证
{
    public static class LogClientExtension
    {
        /*
         * 日志提供者应该决定到底用什么方式纪录日志
         * 
         * 这里仅仅只是提供注册，同时调用时只会注册第一个
         * 
         */

        public static IServiceCollection AddFileLogClient(this IServiceCollection  services)
        {
            services.TryAddSingleton<ILogClient, FileLogClient>();
            return services;
        }

        public static IServiceCollection AddConsoleLogClient(this IServiceCollection services)
        {
            services.TryAddSingleton<ILogClient, ConsoleLogClient>();
            return services;
        }
    }
}