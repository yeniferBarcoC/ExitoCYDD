using System.Globalization;
using System.Xml.Xsl.Runtime;
using System;
namespace Dominio
{
    public class Producto
    {
        private int IdProducto{get;set;}
        private DateTime FechaCompra{get;set;}
        private DateTime FechaVenta{get;set;}
        private double PrecioCompra{get;set;}
        private double PrecioVenta{get;set;}

        public Producto (int IdProducto, DateTime FechaCompra, DateTime FechaVenta, double PrecioCompra, double PrecioVenta ){
            this.IdProducto = idProducto;
            this.FechaCompra = fechaCompra;
            this.FechaVenta = fechaVenta;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
        }
        
    }
}