using System.Collections.Generic;
using ConsolasExito.App.Dominio;


namespace ConsolasExito.App.Persistencia
{
    public interface IRepositorioEmpleados {

        public List<Empleado> consultarTodosAdminC();
        public List<Empleado> consultarTodosAdminS();

        public void guardarEmpleado(Empleado empleado);

        public void eliminarEmpleado(int id);

        public Empleado actualizarEmpleado(Empleado empleado);

        public Empleado consultarEmpleadoPorNombre(Empleado empleado);
        
    }
}