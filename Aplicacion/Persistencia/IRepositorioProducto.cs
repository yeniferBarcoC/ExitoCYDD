using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioProducto
    {
         public List<Producto> consultarTodosAdmin();
         public void guardarProducto (Producto producto);
         public void eliminarProducto (int id);
         public Producto actualizarProducto (Producto producto);
         public Producto consultarProductoPorPrecioVenta (double precioVenta); 
    }
}