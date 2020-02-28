﻿using Microsoft.Extensions.Logging;
using Papiku.Core;

namespace Papiku
{
    internal class Program
    {
        private static void Main(string[] args)
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
            ILogger logger = loggerFactory.CreateLogger<Program>();

            //  logger.LogInformation("Example log message");
            //  logger.LogWarning("I am a warning!");

            PapikuEntryPoint.Instance.Start();
        }
    }
}