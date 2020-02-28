using Microsoft.Extensions.Logging;

namespace Papiku.Helpers.Logger
{
    internal class LoggerHelper
    {
        public static ILogger DefaultLogger<T>()
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                    .AddConsole()
                    .AddEventLog();
            });
            ILogger logger = loggerFactory.CreateLogger<T>();
            return logger;
        }
    }
}