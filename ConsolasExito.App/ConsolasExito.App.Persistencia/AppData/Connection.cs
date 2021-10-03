using System;
using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;


namespace ConsolasExito.App.Persistencia
{
    public class Connection : DbContext
    {
        
        /* Initial Catalog -> nombre base de datos */
        private string connectionString = "Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ExitoData" ;
        
        /* Tablas */
        
        public DbSet<Empleado> Empleados {get; set;}
        public DbSet<Producto> Productos {get; set;}
        public DbSet<Factura> Facturas {get; set;}
        public DbSet<Consola> Consolas {get; set;}
        public DbSet<Control> Controles {get; set;}
        public DbSet<VideoJuego> VideoJuegos {get; set;}
         
        //Metodo para poder crear la base de datos y sus respectivas tablas
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }

}
