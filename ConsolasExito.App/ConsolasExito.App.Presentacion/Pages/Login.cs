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
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario {get;set;}

        [BindProperty]
        public string Contrasenna {get;set;}

        [BindProperty]
        public string MensajeUsuario {get;set;}

        [BindProperty]
        public string MensajeContrasenna {get;set;}

        public void OnGet()
        {

        }

        private readonly ILogger<IndexModel> _logger;

        public LoginModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost(){
            Connection connection = new Connection();
            Empleado empleado = connection.Empleados.FirstOrDefault(e => e.Usuario == Usuario);
            if(empleado != null){
                if(empleado.PrimerIngreso){
                    HttpContext.Session.SetString("username", Usuario);
                    return RedirectToPage("/CambiarContrasena/CambiarContrasena");
                }
                if(empleado.Contrasenna.Equals (Contrasenna)){
                    return RedirectToPage("/CrudEmpleado/Index");
                }else{
                    MensajeContrasenna = "La contraseña es incorrecta";
                    return Page();
                }
            }else{
                MensajeUsuario = "El usuario no ha sido encontrado";
                return Page();
            }
        }
    }
}