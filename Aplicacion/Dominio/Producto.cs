using System;
using System.Globalization;
using System.Collections.Generic;

namespace Dominio
{
    public class Producto
    {
        public int Id {get; set; }


        //private DateTime FechaCompra{get;set;}
        //private DateTime FechaVenta{get;set;}

        public string FechaCompra{get;set;}
        public string FechaVenta{get;set;}
        public double PrecioCompra{get;set;}
        public double PrecioVenta{get;set;}
        public TipoProducto TipoProducto {get; set;}

        
    }
}