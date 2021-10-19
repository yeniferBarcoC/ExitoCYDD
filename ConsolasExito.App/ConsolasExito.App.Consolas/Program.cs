using System;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;


namespace ConsolasExito.App.Consolas
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioProducto repositorioProducto = new RepositorioProducto();
            ConsolasExito.App.Dominio.Producto producto = new ConsolasExito.App.Dominio.Producto();
            
        }

        /*public static void guardarEmpleado(){
            ConsolasExito.App.Dominio.Empleado em = new ConsolasExito.App.Dominio.Empleado();
            Connection Conn = new Connection();
           
            em.Cedula = "1107";
            em.Codigo = "AS-01";
            em.Nombre = "Daniela";
            em.Apellido = "Diaz";
            em.Sucursal = "Principal";
            em.Usuario = "DDiaz";
            em.Contrasenna = "1107";
            em.TipoEmpleado = TipoEmpleado.ADMINISTRADOR_SISTEMA;

            /* Instrucciones para agregar los datos a la tabla 
            Conn.Empleados.Add(em);
            Conn.SaveChanges();
            Console.WriteLine("El id del empleado es: " + em.Id);

            RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();
            ConsolasExito.App.Dominio.Empleado empleado = new ConsolasExito.App.Dominio.Empleado();
           
            empleado.Cedula = "1110";
            empleado.Codigo = "AS-01";
            empleado.Nombre = "Daniel";
            empleado.Apellido = "Diaz";
            empleado.Sucursal = "Principal";
            empleado.Usuario = "DDDiaz";
            empleado.Contrasenna = "1110";
            empleado.TipoEmpleado = TipoEmpleado.EMPLEADO_VENTAS;

            repositorioEmpleado.guardarEmpleado(empleado);
        }*/
    }
}
