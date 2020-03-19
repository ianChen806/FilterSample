using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterSampleForMvc.Filters
{
    public class MyGlobalFilter : IAsyncActionFilter
    {
        private readonly ILogger<MyGlobalFilter> _logger;

        public MyGlobalFilter(ILogger<MyGlobalFilter> logger)
        {
            _logger = logger;
            Console.WriteLine($"{nameof(MyGlobalFilter)} logger is null {logger == null}");
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context,
                                                 ActionExecutionDelegate next)
        {
            Console.WriteLine($"{nameof(MyGlobalFilter)}: ing");
            await next();
            Console.WriteLine($"{nameof(MyGlobalFilter)}: ed");
        }
    }
}