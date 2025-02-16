namespace FirstWebApp
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next) 
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"Metod={context.Request.Method}");
            await _next(context);
        }
    }
}
