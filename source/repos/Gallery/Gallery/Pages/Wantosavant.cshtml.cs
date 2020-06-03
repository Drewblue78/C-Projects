using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gallery.Pages
{
    public class WantosavantModel : PageModel {
        private readonly ILogger<WantosavantModel> _logger;
        public WantosavantModel(ILogger<WantosavantModel> logger) {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}