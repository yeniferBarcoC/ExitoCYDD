using System;
using System.Collections.Generic;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioEmpleados : IRepositorioEmpleados   

    {
        conexion conexion1 = new conexion();

        public List<Empleados> consultarTodosAdmin(){
            return conexion1.Empleados.Where(e => e.TipoEmpleado == TipoEmpleado.ADMINISTRADOR_SISTEMA).ToList();
        }
         public void guardarEmpleado (Empleados empleado){
             conexion1.Empleados.Add(empleado);
             conexion1.SaveChanges();
         }
         public void eliminarEmpleado (int id){
             var empleado = conexion1.Empleados.First(e => e.Id == id);
             conexion1.Empleados.Remove(empleado);
             conexion1.SaveChanges();
         }
         public Empleados actualizarEmpleado (Empleados empleado){
             var empleadoBusqueda = conexion1.Empleados.First(e => e.Id == empleados.Id);
             empleadoBusqueda.Cedula = empleado.Cedula;
             empleadoBusqueda.Codigo = empleado.Codigo;
             empleadoBusqueda.Nombre = empleado.Nombre;
             empleadoBusqueda.Apellido = empleado.Apellido;
             empleadoBusqueda.Sucursal = empleado.Sucursal;
             empleadoBusqueda.Usuario = empleado.Usuario;
             empleadoBusqueda.Contrasenna = empleado.Contrasenna;
             empleadoBusqueda.TipoEmpleado = empleado.TipoEmpleado;
             conexiones.SaveChanges();

             return empleadoBusqueda;
         }
         public Empleados consultarEmpleadoPorCedula (string cedula){
             var empleadoBusqueda = conexion1.Empleados.First(e => e.Cedula == empleados.Cedula);
             return empleadoBusqueda;
         }

    }
}