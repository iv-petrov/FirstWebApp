namespace FirstWebApp.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly ILogger _logger;
        public LoggingService()
        {
            _logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("ToDo");
        }
        public void Log(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
