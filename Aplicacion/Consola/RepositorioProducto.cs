using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioProducto : IRepositorioProducto
    {
        conexion conexiones = new conexion();

        public List<Producto> consultarTodosAdmin(){
            return conexiones.Productos.Where(e => e.TipoProducto == TipoProducto.CONSOLAS).ToList();
        }
        public void guardarProducto (Producto producto){
             conexiones.Productos.Add(producto);
             conexiones.SaveChanges();
         }
        public void eliminarProducto (int id){
            var producto = conexiones.Productos.First(p => p.Id == id);
            conexiones.Productos.Remove(producto);
            conexiones.SaveChanges();
        }
        public void actualizarProducto (Producto producto){
            var productoBusqueda = conexiones.Productos.First(p => p.Id == producto.Id);
             productoBusqueda.FechaCompra = producto.FechaCompra;
             productoBusqueda.FechaVenta = producto.FechaVenta;
             productoBusqueda.PrecioCompra = producto.PrecioCompra;
             productoBusqueda.PrecioVenta = producto.PrecioVenta;
             productoBusqueda.TipoProducto = producto.TipoProducto;
             
            /* if(productoBusqueda.TipoProducto == "CONSOLAS"){
                var consolaBusqueda = conexiones.ConsolasP.First(p => p.Id == consola.IdConsolasP);
                consolaBusqueda.Nombre = ConsolasP.Nombre;
                consolaBusqueda.Version = ConsolasP.Version;
                consolaBusqueda.Fabricante = ConsolasP.Fabricante;
                consolaBusqueda.CapacidadAlmacenamiento = ConsolasP.CapacidadAlmacenamiento;
                consolaBusqueda.TipoAlmacenamiento = ConsolasP.TipoAlmacenamiento;
                consolaBusqueda.VelocidadRam = ConsolasP.VelocidadRam;
                consolaBusqueda.VelocidadProcesamiento = ConsolasP.VelocidadProcesamiento;
                consolaBusqueda.NumeroControles = ConsolasP.NumeroControles;

             } else if(productoBusqueda.TipoProducto == "CONTROLES"){
                var controlesBusqueda = conexiones.Controles.First(p => p.Id == controles.IdControles);
                controlesBusqueda.TipoControl = Controles.TipoControl;

             }else{
                var videoJuegoBusqueda = conexiones.VideoJuego.First(p => p.Id == videoJuego.IdVideoJuego);
                videoJuegoBusqueda.Nombre = VideoJuego.Nombre;
                videoJuegoBusqueda.Version = VideoJuego.Version;
                videoJuegoBusqueda.Fabricante = VideoJuego.Fabricante;
                videoJuegoBusqueda.EsMultiPlataforma = VideoJuego.EsMultiPlataforma;
             }*/

             conexiones.SaveChanges();
        }
        public Producto consultarProductoPorPrecioVenta (double precioVenta){
            var productoBusqueda = conexiones.Productos.First(p => p.PrecioVenta == precioVenta);
            return productoBusqueda;
        }
    }
}