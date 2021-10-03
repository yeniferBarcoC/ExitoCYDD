using ConsolasExito.App.Persistencia;
using ConsolasExito.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ConsolasExito.App.Consolas
{
    public class RepositorioProducto : IRepositorioProductos {
 
        Connection Conn = new Connection();

        public List<Producto> consultarConsolas(){
            return Conn.Productos.Where(p => p.TipoProducto == TipoProducto.CONSOLA).ToList(); 
        }
        public List<Producto> consultarControles(){
            return Conn.Productos.Where(p => p.TipoProducto == TipoProducto.CONTROL).ToList(); 
        }
        public List<Producto> consultarVideojuegos(){
            return Conn.Productos.Where(p => p.TipoProducto == TipoProducto.VIDEOJUEGO).ToList(); 
        }

        public void guardarProducto(Producto producto){
            Conn.Productos.Add(producto);
            Conn.SaveChanges();
        }
        public void eliminarProducto(int id){
            var producto = Conn.Productos.First(p => p.Id == id);
            Conn.Productos.Remove(producto);
            Conn.SaveChanges();
        }

        public Producto actualizarProducto(Producto producto){
            var productoBusqueda = Conn.Productos.First(p => p.Id == producto.Id);
        /*     productoBusqueda.Nombre = producto.Nombre;
            productoBusqueda.Apellido = producto.Apellido;
            productoBusqueda.Cedula = producto.Cedula;
            productoBusqueda.Sucursal = producto.Sucursal;
            productoBusqueda.Codigo = producto.Codigo;
            productoBusqueda.Contrasenna = producto.Contrasenna;
            productoBusqueda.TipoEmpleado = producto.TipoEmpleado;
 */
            Conn.SaveChanges();
            return productoBusqueda; 
        }


    }
}