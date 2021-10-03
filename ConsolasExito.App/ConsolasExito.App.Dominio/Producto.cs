using System;

namespace ConsolasExito.App.Dominio
{
    public class Producto
    {
        public int Id {get; set; }
        public string FechaCompra{get;set;}
        public string FechaVenta{get;set;}
        public double PrecioCompra{get;set;}
        public double PrecioVenta{get;set;}
         public TipoProducto TipoProducto {get; set;} 
    
        /*  public Producto(int id, string fechaCompra, string fechaVenta, double precioCompra, double precioVenta, TipoProducto tipoProducto){
          this.Id = id;
          this.FechaCompra = fechaCompra;
          this.FechaVenta = fechaVenta;
          this.PrecioCompra = precioCompra;
          this.PrecioVenta = precioVenta;
          this.TipoProducto = tipoProducto;
        }  */

    }
}
