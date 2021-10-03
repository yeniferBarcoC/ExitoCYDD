using System;

namespace ConsolasExito.App.Dominio
{
    public class Consola : Producto
    {
       /*  public int Id {get; set;} */
        public string Nombre{get; set;}
        public string Version{get; set;}
        public string Fabricante{get; set;}
        public double CapacidadAlmacenamiento{get; set;}
        public TipoAlmacenamiento TipoAlmacenamiento{get; set;}
        public string VelocidadRam{get; set;}
        public string VelocidadProcesamiento{get; set;}
        public int NumeroControles{get; set;}

    }
}