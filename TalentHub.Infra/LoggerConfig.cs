using Microsoft.Extensions.Logging;

namespace TalentHub.Infra
{
    public static class LoggerConfig
    {
        private static ILoggerFactory? _loggerFactory;

        public static ILoggerFactory LoggerFactory
        {
            get
            {
                if (_loggerFactory == null)
                {
                    _loggerFactory = Microsoft.Extensions.Logging.LoggerFactory.Create(builder =>
                    {
                        builder
                            .AddConsole()
                            .AddJsonConsole()                            
                            .SetMinimumLevel(LogLevel.Information); // Define o nível mínimo de log
                    });
                }
                return _loggerFactory;
            }
        }

        public static ILogger<T> CreateLogger<T>() => LoggerFactory.CreateLogger<T>();
    }
}
