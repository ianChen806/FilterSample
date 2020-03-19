using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterSampleForRzorPage.Filters
{
    public class MyPageFilter : IAsyncPageFilter
    {
        private readonly ILogger<MyPageFilter> _logger;

        public MyPageFilter(ILogger<MyPageFilter> logger)
        {
            _logger = logger;
            Console.WriteLine($"page logger is null {logger == null}");
        }
        
        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            Console.WriteLine($"Page:" + nameof(OnPageHandlerExecutionAsync)+" ing");
            await next();
            Console.WriteLine($"Page:" + nameof(OnPageHandlerExecutionAsync)+" ed");
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            Console.WriteLine($"Page:" + nameof(OnPageHandlerSelectionAsync));
            return Task.CompletedTask;
        }
    }
}