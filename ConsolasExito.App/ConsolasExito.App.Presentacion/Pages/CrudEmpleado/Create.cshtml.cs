using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;

namespace ConsolasExito.App.Presentacion.Pages.CrudEmpleado
{
    public class CreateModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Connection _context;

        public CreateModel(ConsolasExito.App.Persistencia.Connection context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        [BindProperty]
        public string MensajeInvalido { get; set; }
        //public TipoEmpleado TipoEmpleado { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                MensajeInvalido = "Error al crear el usuario";
                return RedirectToPage("../../Index");
            }

            Empleado.PrimerIngreso = true;
            _context.Empleados.Add(Empleado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
