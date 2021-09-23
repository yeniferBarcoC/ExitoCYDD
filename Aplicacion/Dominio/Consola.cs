using System.Runtime.Intrinsics.Arm.Arm64;
using System;
namespace Dominio
{
    public class Consola : Producto
    {
        private int IdConsola{get; set;}
        private string Nombre{get; set;}
        private string Version{get; set;}
        private string Fabricante{get; set;}
        private double CapacidadAlmacenamiento{get; set;}
        private TipoAlmacenamiento TipoAlmacenamiento{get; set;}
        private string VelocidadRam{get; set;}
        private string VelocidadProcesamiento{get; set;}
        private int NumeroControles{get; set;}

        public Consola(int IdProducto, Date FechaCompra, Date FechaVenta, Double PrecioCompra, Double PrecioVenta,int IdConsola,string Nombre,string Version,string Fabricante,double CapacidadAlmacenamiento,TipoAlmacenamiento TipoAlmacenamiento,string VelocidadRam,string VelocidadProcesamiento,int NumeroControles ):base (IdProducto, FechaCompra, FechaVenta, PrecioCompra,PrecioVenta){
                this.IdConsola = idConsola;
                this.Nombre = nombre;
                this.Version = version;
                this.Fabricante = fabricante;
                this.CapacidadAlmacenamiento = capacidadAlmacenamiento;
                this.TipoAlmacenamiento = tipoAlmacenamiento;
                this.VelocidadRam = velocidadRam;
                this.VelocidadProcesamiento = velocidadProcesamiento;
                this.NumeroControles = numeroControles;
            }
    }
}