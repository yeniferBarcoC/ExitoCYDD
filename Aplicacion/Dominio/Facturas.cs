using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Facturas
    {
        public int Id {get;set;}


        public Empleados Empleados {get;set;}
        public Producto producto {get; set;}
        public List<Producto> listaProductos {get;set;}
    }
}