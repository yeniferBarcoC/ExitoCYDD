using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioFactura : IRepositorioFactura
    {
        conexion conexion2 = new conexion();

        /*public List<Facturas> consultarTodosAdmin(){
            return conexion2.Facturas.Where(f => f.Id == Facturas.Id).ToList(); 
        }*/
        public void guardarFactura (Facturas facturas){
            conexion2.Facturas.Add(facturas);
            conexion2.SaveChanges();
        }
        public void eliminarFactura (int id){
            var facturas = conexion2.Facturas.First(f => f.Id == id);
            conexion2.Facturas.Remove(facturas);
            conexion2.SaveChanges();
        }
        public void actualizarFactura (Facturas facturas){
            var facturaBusqueda = conexion2.Facturas.First(f => f.Id == facturas.Id);
             facturaBusqueda.Empleados = facturas.Empleados;
             facturaBusqueda.Producto = facturas.Producto;
             facturaBusqueda.ListaProductos = facturas.ListaProductos;
             conexion2.SaveChanges();
        }
        public Facturas consultarFacturaPorId (int id){
            var facturaBusqueda = conexion2.Facturas.First(f => f.Id == id);
            return facturaBusqueda;
        }
    }
}