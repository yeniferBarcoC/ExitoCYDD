using System;
using System.Collections.Generic;

namespace ConsolasExito.App.Dominio

{
    public class Factura
    {
        public int Id {get; set;}
        public Empleado Empleado {get; set;}
        public Producto producto {get; set;}
        public List<Producto> listaProductos {get; set;}
    }
}