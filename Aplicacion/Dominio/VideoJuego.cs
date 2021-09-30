using System;

namespace Dominio
{
    public class VideoJuego : Producto
    {
        public int IdVideoJuego{get; set;}
        public string Nombre{get; set;}
        public string Version{get; set;}
        public string Fabricante{get; set;}
        public Boolean EsMultiPlataforma{get; set;}

    }
}