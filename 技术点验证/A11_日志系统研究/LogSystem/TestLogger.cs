using System;
using Microsoft.Extensions.Logging;

namespace 技术点验证
{
    public class TestLogger : ILogger
    {
        private readonly string? categoryName;
        private readonly ILogClient logClient;

        public TestLogger(string? categoryName, ILogClient logClient)
        {
            this.categoryName = categoryName;
            this.logClient = logClient;
        }

        public IDisposable? BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId, TState state,
            Exception exception,
            Func<TState, Exception, string?> formatter)
        {
            throw new NotImplementedException();
        }
    }
}