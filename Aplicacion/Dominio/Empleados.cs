using System;
using System.Globalization;
//using Persistencia;

namespace Dominio
{
    public class Empleados
    {
        public int Id {get; set;}

        public string Cedula {get; set;}
        public string Codigo {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Sucursal {get; set;}
        public string Usuario {get; set;}
        public string Contrasenna {get; set;}
        public TipoEmpleado TipoEmpleado {get; set;}
    }
}