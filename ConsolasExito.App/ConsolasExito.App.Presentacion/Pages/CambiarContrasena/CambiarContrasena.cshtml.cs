using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ConsolasExito.App.Presentacion.Pages
{
    public class CambiarContrasenaModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public CambiarContrasenaModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
