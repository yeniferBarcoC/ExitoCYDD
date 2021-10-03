using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;

namespace ConsolasExito.App.Presentacion.Pages.CrudConsola
{
    public class DeleteModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Connection _context;

        public DeleteModel(ConsolasExito.App.Persistencia.Connection context)
        {
            _context = context;
        }

        [BindProperty]
        public Consola Consola { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consola = await _context.Consolas.FirstOrDefaultAsync(m => m.Id == id);

            if (Consola == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consola = await _context.Consolas.FindAsync(id);

            if (Consola != null)
            {
                _context.Consolas.Remove(Consola);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
