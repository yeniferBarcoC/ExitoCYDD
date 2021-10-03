using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;

namespace ConsolasExito.App.Presentacion.Pages.CrudVideoJuego
{
    public class IndexModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Connection _context;

        public IndexModel(ConsolasExito.App.Persistencia.Connection context)
        {
            _context = context;
        }

        public IList<VideoJuego> VideoJuego { get;set; }

        public async Task OnGetAsync()
        {
            VideoJuego = await _context.VideoJuegos.ToListAsync();
        }
    }
}
