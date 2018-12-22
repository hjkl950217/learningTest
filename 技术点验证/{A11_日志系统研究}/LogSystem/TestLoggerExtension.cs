using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace 技术点验证
{
    public static class TestLoggerExtension
    {
        public static ILoggingBuilder AddTestLogger(this ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddFilter
            loggingBuilder.Services.AddConsoleLogClient();
            loggingBuilder.Services.AddSingleton<ILoggerProvider, TestLoggerProvider>();
            return loggingBuilder;
        }
    }
}