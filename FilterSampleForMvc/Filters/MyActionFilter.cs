using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterSampleForMvc.Filters
{
    public class MyActionFilter : IAsyncActionFilter
    {
        private readonly ILogger<MyActionFilter> _logger;

        public MyActionFilter(ILogger<MyActionFilter> logger)
        {
            _logger = logger;
            Console.WriteLine($"{nameof(MyActionFilter)} logger is null {logger == null}");
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, 
                                                 ActionExecutionDelegate next)
        {
            Console.WriteLine($"{nameof(MyActionFilter)}: ing");
            await next();
            Console.WriteLine($"{nameof(MyActionFilter)}: ed");
        }
    }
}