using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ConsolasExito.App.Persistencia;
using ConsolasExito.App.Dominio;
using Microsoft.AspNetCore.Http;

namespace ConsolasExito.App.Presentacion.Pages
{
    public class CambiarContrasenaModel : PageModel
    {
        [BindProperty]
        public string ContrasennaNueva {get;set;}

        [BindProperty]
        public string RepitaContrasenna {get;set;}

        [BindProperty]
        public string MensajeContrasenna {get;set;}
        
        private readonly ILogger<IndexModel> _logger;

        public CambiarContrasenaModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {            
        } 

        public void OnPost()
        {
            Connection conn = new Connection();
            var Username = HttpContext.Session.GetString("username");
            HttpContext.Session.Remove("username");
            Empleado empleado = conn.Empleados.FirstOrDefault(e => e.Usuario == Username);

            if(!ContrasennaNueva.Equals(RepitaContrasenna)){
                MensajeContrasenna = "Las contraseñas no coinciden";
            }else{
                empleado.Contrasenna = ContrasennaNueva;
                empleado.PrimerIngreso = false;
                conn.SaveChanges();
            }
        }
    }
}
