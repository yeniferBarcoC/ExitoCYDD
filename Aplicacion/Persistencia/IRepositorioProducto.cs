using System.Collections.Generic;
using System;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioProducto
    {
         public List<Producto> consultarTodosAdmin();
         public void guardarProducto (Producto producto);
         public void eliminarProducto (int id);
         public void actualizarProducto (Producto producto);
         public Producto consultarProductoPorPrecioVenta (double precioVenta); 
    }
}