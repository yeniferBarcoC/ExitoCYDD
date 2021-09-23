using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Factura
    {
        private int IdFactura{get;set;}
        private Empleado Empleado{get;set;}
        private List<Producto> Producto{get;set;}

        public Factura(int IdFactura, Empleado Empleado,List<Producto> Producto){
            this.IdFactura = idFactura;
            this.Empleado = empleado;
            this.Producto = producto;
        }
        
    }
}