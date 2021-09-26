using System;
using System.Collections.Generic;
using Persistencia;
using Dominio;

namespace Consola
{
    public class RepositorioFactura : IRepositorioFactura
    {
        conexion conexiones = new conexion();

        public List<Facturas> consultarTodosAdmin(){
            return conexiones.Facturas.Where(f => f.Id == Id).ToList();
        }
        public void guardarFactura (Facturas facturas){
            conexiones.Facturas.Add(facturas);
            conexiones.SaveChanges();
        }
        public void eliminarFactura (int id){
            var facturas = conexiones.Facturas.First(f => f.Id == id);
            conexiones.Facturas.Remove(facturas);
            conexiones.SaveChanges();
        }
        public Facturas actualizarFactura (Facturas facturas){
            var facturaBusqueda = conexiones.Facturas.First(f => f.Id == facturas.Id);
             facturaBusqueda.Empleados = facturas.Empleados;
             facturaBusqueda.Producto = facturas.Producto;
             facturaBusqueda.listaProductos = facturas.listaProductos;
             conexiones.SaveChanges();

             return facturaBusqueda;
        }
        public Facturas consultarFacturaPorEmpleado (string empleado){
            var facturaBusqueda = conexiones.Facturas.First(f => f.Empleados.empleado == Facturas.Empleado);
            return facturaBusqueda;
        }
    }
}