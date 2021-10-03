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
    public class IndexModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Connection _context;

        public IndexModel(ConsolasExito.App.Persistencia.Connection context)
        {
            _context = context;
        }

        public IList<Consola> Consola { get;set; }

        public async Task OnGetAsync()
        {
            Consola = await _context.Consolas.ToListAsync();
        }
    }
}
