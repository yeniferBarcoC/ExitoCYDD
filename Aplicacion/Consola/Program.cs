using System;
using Dominio;
using Persistencia;
using System.Linq;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public void guardar(){
            RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();
            Empleados empleado = new Empleados();
            empleado.Cedula = "1234";
            empleado.Codigo = "AS123";
            empleado.Nombre = "Sara";
            empleado.Apellido = "Suarez";
            empleado.Sucursal = "Antioquia";
            empleado.Usuario = "sasuAnt";
            empleado.Contrasenna = "12345";
            empleado.TipoEmpleado = TipoEmpleado.ADMINISTRADOR_SISTEMA;
            repositorioEmpleados.guardarEmpleado(empleado);
            Console.WriteLine("El Id del empleado es: " + empleado.Id);
        }

        public void eliminar(){
            RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();
            Empleados empleado = new Empleados();
            repositorioEmpleados.eliminarEmpleado(1);
            Console.WriteLine("Empleado eliminado");
        }

        public void actualizar(){
            RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();
            Empleados empleado = new Empleados();
            empleado.Id = 2;
            empleado.Cedula = "2234";
            empleado.Codigo = "AV123";
            empleado.Nombre = "Francisco";
            empleado.Apellido = "Gomez";
            empleado.Sucursal = "Bogota";
            empleado.Usuario = "frangoBo";
            empleado.Contrasenna = "22345";
            empleado.TipoEmpleado = TipoEmpleado.ADMINISTRADOR_VENTAS;
            repositorioEmpleados.actualizarEmpleado(empleado);
            Console.WriteLine("El empleado " + empleado.Id + " ha sido actualizado.");
        }

        public void buscar(){
            RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();
            Empleados empleado = new Empleados();
            repositorioEmpleados.consultarEmpleadoPorCedula("1234");
            Console.WriteLine("El empleado es: " + empleado.TipoEmpleado);
        }
    }
}
