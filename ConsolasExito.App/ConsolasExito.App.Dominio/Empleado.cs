using System;

namespace ConsolasExito.App.Dominio
{
    public class Empleado
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
    
        public Empleado(){
          
        }

        public Empleado(string cedula, string codigo, string nombre, string apellido, string sucursal, string usuario, string contrasenna, TipoEmpleado tipoEmpleado){
         
          this.Cedula = cedula;
          this.Codigo = codigo;
          this.Nombre = nombre;
          this.Apellido = apellido;
          this.Sucursal = sucursal;
          this.Usuario = usuario;
          this.Contrasenna = contrasenna;
          this.TipoEmpleado = tipoEmpleado;
        }

    }
}
