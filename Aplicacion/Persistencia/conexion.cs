//using System;
//using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class conexion : DbContext
    {
        public DbSet <Empleados> empleados {get; set;}

        public DbSet <Facturas> facturas {get; set;}

        public DbSet <Producto> productos {get; set;}

        public DbSet <ConsolasP> consolas {get; set;}

        public DbSet <Controles> controles {get; set;}

        public DbSet <VideoJuego> videoJuegos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ExitoData");
            }
        }
    }
}