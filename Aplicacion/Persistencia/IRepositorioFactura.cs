using System.Collections.Generic;
using System;
using Dominio;

namespace Persistencia 
{
    public interface IRepositorioFactura
    {
         //public List<Facturas> consultarTodosAdmin();
         public void guardarFactura (Facturas facturas);
         public void eliminarFactura (int id);
         public void actualizarFactura (Facturas facturas);
         public Facturas consultarFacturaPorId (int id); 
    }
}