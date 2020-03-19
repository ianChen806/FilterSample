using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FilterSampleForMvc.Middlewares
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("MyMiddleware ing");
            await _next.Invoke(context);
            Console.WriteLine("MyMiddleware ed");
        }
    }
}