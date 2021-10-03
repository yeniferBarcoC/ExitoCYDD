using ConsolasExito.App.Persistencia;
using ConsolasExito.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ConsolasExito.App.Consolas
{
    public class RepositorioEmpleado : IRepositorioEmpleados {

        Connection Conn = new Connection();
        public List<Empleado> consultarTodosAdminC(){
            return Conn.Empleados.Where(e => e.TipoEmpleado == TipoEmpleado.ADMINISTRADOR_COMPRAS).ToList();
        }

        public List<Empleado> consultarTodosAdminS(){
            return Conn.Empleados.Where(e => e.TipoEmpleado == TipoEmpleado.ADMINISTRADOR_SISTEMA).ToList();
        }

        public void guardarEmpleado(Empleado empleado){
            Conn.Empleados.Add(empleado);
            Conn.SaveChanges();
        }

        public void eliminarEmpleado(int id){
            var empleado = Conn.Empleados.First(e => e.Id == id);
            Conn.Empleados.Remove(empleado);
            Conn.SaveChanges();
        }

        public Empleado actualizarEmpleado(Empleado empleado){
            var empleadoBusqueda = Conn.Empleados.First(e => e.Id == empleado.Id);
            empleadoBusqueda.Nombre = empleado.Nombre;
            empleadoBusqueda.Apellido = empleado.Apellido;
            empleadoBusqueda.Cedula = empleado.Cedula;
            empleadoBusqueda.Sucursal = empleado.Sucursal;
            empleadoBusqueda.Codigo = empleado.Codigo;
            empleadoBusqueda.Contrasenna = empleado.Contrasenna;
            empleadoBusqueda.TipoEmpleado = empleado.TipoEmpleado;

            Conn.SaveChanges();
            return empleadoBusqueda;
        }

        public Empleado consultarEmpleadoPorNombre(Empleado empleado){
            var empleadoBusqueda = Conn.Empleados.First(e => e.Nombre == empleado.Nombre);
            return empleadoBusqueda;
        }
        

    }
}
