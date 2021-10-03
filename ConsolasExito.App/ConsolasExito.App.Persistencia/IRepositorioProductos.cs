using System.Collections.Generic;
using ConsolasExito.App.Dominio;


namespace ConsolasExito.App.Persistencia
{
    public interface IRepositorioProductos{

        public List<Producto> consultarConsolas();
        public List<Producto> consultarControles();
        public List<Producto> consultarVideojuegos();
        public void guardarProducto(Producto producto);
        public void eliminarProducto(int id);
        public Producto actualizarProducto(Producto producto);

    }
}