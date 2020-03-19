using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterSampleForRzorPage.Filters
{
    public class MyGlobalFilter : IAsyncPageFilter
    {
        private readonly MyClass _test;

        public MyGlobalFilter(MyClass test)
        {
            _test = test;
        }
        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            Console.WriteLine("Global:" + nameof(OnPageHandlerExecutionAsync)+" ind");
            await next();
            Console.WriteLine("Global:" + nameof(OnPageHandlerExecutionAsync)+" ed");
            
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            Console.WriteLine("Global:" + nameof(OnPageHandlerSelectionAsync));
            return Task.CompletedTask;
        }
    }
}