using System;

namespace ConsolasExito.App.Dominio
{
    public class VideoJuego : Producto
    {
       /*  public int Id {get; set;} */
        public string Nombre{get; set;}
        public string Version{get; set;}
        public string Fabricante{get; set;}
        public Boolean EsMultiPlataforma{get; set;}

    }
}