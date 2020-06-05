using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspnetcoreappfordocker.Pages
{
    public class DockerModel : PageModel
    {
        private readonly ILogger<DockerModel> _logger;

        public DockerModel(ILogger<DockerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
