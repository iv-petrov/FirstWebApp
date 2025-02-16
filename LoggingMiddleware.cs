namespace FirstWebApp
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next) 
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine(context.Request.QueryString);
            await _next(context);
        }
    }
}
