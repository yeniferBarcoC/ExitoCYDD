using System;
namespace Dominio
{
    public class VideoJuego : Producto
    {
        private int IdVideoJuego{get; set;}
        private string Nombre{get; set;}
        private string Version{get; set;}
        private string Fabricante{get; set;}
        private Boolean EsMultiPlataforma{get; set;}

        public VideoJuego(int IdProducto, Date FechaCompra, Date FechaVenta, Double PrecioCompra, Double PrecioVenta,int IdVideoJuego,string Nombre,string Version,string Fabricante, Boolean EsMultiPlataforma):base (IdProducto, FechaCompra, FechaVenta, PrecioCompra,PrecioVenta){
                this.IdVideoJuego = idVideoJuego;
                this.Nombre = nombre;
                this.Version = version;
                this.Fabricante = fabricante;
                this.EsMultiPlataforma = esMultiPlataforma;
            }
    }
}