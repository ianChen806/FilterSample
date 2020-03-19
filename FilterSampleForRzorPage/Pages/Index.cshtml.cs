using System;
using FilterSampleForRzorPage.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FilterSampleForRzorPage.Pages
{
    [TypeFilter(typeof(MyPageFilter))]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Console.WriteLine(nameof(OnGet));
        }
    }
}