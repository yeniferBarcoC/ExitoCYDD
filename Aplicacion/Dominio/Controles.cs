namespace Dominio
{
    public class Controles : Producto
    {
        private int IdControles{get;set;}
        private string TipoControl{get;set;}

        public Controles(int IdProducto, Date FechaCompra, Date FechaVenta, Double PrecioCompra, Double PrecioVenta,int IdControles,string TipoControl):base (IdProducto, FechaCompra, FechaVenta, PrecioCompra,PrecioVenta){
                this.IdControles = idControles;
                this.TipoControl = tipoControl;
        }
    }
}