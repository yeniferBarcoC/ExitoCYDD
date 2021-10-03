using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;

namespace ConsolasExito.App.Presentacion.Pages.CrudControl
{
    public class DetailsModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Connection _context;

        public DetailsModel(ConsolasExito.App.Persistencia.Connection context)
        {
            _context = context;
        }

        public Control Control { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Control = await _context.Controles.FirstOrDefaultAsync(m => m.Id == id);

            if (Control == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
