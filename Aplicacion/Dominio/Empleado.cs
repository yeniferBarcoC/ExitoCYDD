using System;
using System.Globalization;
namespace Dominio
{
    public class Empleado
    {

         private int IdEmpleado {get;set;}
         private string Cedula {get;set;}
         private string CodigoEmpleado {get;set;}
         private string Nombre {get;set;}
         private string Apellido {get;set;}
         private string Sucursal {get;set;}
         private string Usuario {get;set;}
         private string Contrasenna {get;set;}
         private TipoEmpleado TipoEmpleado {get;set;}

         public Empleado (int IdEmpleado,string Cedula,string CodigoEmpleado,string Nombre,string Apellido,string Sucursal,string Usuario,string Contrasenna,TipoEmpleado TipoEmpleado){
             this.IdEmpleado = idEmpleado;
             this.Cedula = cedula;
             this.CodigoEmpleado = codigoEmpleado;
             this.Nombre = nombre;
             this.Apellido = apellido;
             this.Sucursal = sucursal;
             this.Usuario = iusuario;
             this.Contrasenna = contrasenna;
             this.TipoEmpleado = tipoEmpleado;
         }
        
    }
}