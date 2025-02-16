namespace FirstWebApp.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly ILogger _logger;
        public LoggingService()
        {
            string id = Guid.NewGuid().ToString();
            _logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger($"Logging.Id={id}");
        }
        public void Log(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
