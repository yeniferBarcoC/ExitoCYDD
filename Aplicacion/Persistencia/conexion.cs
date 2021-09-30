using System;
//using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class conexion : DbContext
    {
        public DbSet <Empleados> Empleados {get; set;}

        public DbSet <Facturas> Facturas {get; set;}

        public DbSet <Producto> Productos {get; set;}

        public DbSet <ConsolasP> Consolas {get; set;}

        public DbSet <Controles> Controles {get; set;}

        public DbSet <VideoJuego> VideoJuegos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ExitoData");
            }
        }
    }
}