using System;
using System.Collections.Generic;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioProducto : IRepositorioProducto
    {
        conexion conexiones = new conexion();

        public List<Producto> consultarTodosAdmin(){
            return conexiones.Producto.Where(e => e.TipoProducto == TipoProducto.CONSOLAS).ToList();
        }
        public void guardarProducto (Producto producto){
             conexiones.Producto.Add(producto);
             conexiones.SaveChanges();
         }
        public void eliminarProducto (int id){
            var producto = conexiones.Producto.First(p => p.Id == id);
            conexiones.Producto.Remove(producto);
            conexiones.SaveChanges();
        }
        public Producto actualizarProducto (Producto producto){
            var productoBusqueda = conexiones.Producto.First(p => p.Id == producto.Id);
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

             return productoBusqueda;
        }
        public Producto consultarProductoPorPrecioVenta (double precioVenta){
            var productoBusqueda = conexiones.Producto.First(p => p.PrecioVenta == Producto.precioVenta);
            return productoBusqueda;
        }
    }
}