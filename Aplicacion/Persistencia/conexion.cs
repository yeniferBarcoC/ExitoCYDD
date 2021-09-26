//using System;
//using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class conexion : DbContext
    {
        DbSet <Empleados> empleados {get; set;}

         DbSet <Facturas> facturas {get; set;}

         DbSet <Producto> productos {get; set;}

         DbSet <ConsolasP> consolas {get; set;}

         DbSet <Controles> controles {get; set;}

         DbSet <VideoJuego> videoJuegos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ExitoData");
            }
        }
    }
}