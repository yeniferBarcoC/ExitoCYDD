using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Facturas
    {
        public int Id {get;set;}


        public Empleados Empleados {get;set;}
        public Producto Producto {get; set;}
        public List<Producto> ListaProductos {get;set;}
    }
}