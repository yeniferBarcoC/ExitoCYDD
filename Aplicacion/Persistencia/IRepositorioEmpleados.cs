using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEmpleados
    {
         public List<Empleados> consultarTodosAdmin();
         public void guardarEmpleado (Empleados empleado);
         public void eliminarEmpleado (int id);
         public Empleados actualizarEmpleado (Empleados empleado);
         public Empleados consultarEmpleadoPorCedula (string cedula); 

    }
}