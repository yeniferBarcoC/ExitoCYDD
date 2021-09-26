using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioFactura
    {
         public List<Facturas> consultarTodosAdmin();
         public void guardarFactura (Facturas facturas);
         public void eliminarFactura (int id);
         public Facturas actualizarFactura (Facturas facturas);
         public Facturas consultarFacturaPorEmpleado (string empleado); 
    }
}