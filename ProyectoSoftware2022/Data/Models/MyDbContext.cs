using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoSoftware2022.Data.Settings;

namespace ProyectoSoftware2022.Data.Models
{
    class MyDbContext : DbContext
    {
        public MyDbContext() { 
        //Contrustor por defecto.
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=M_9_DeJulio;Trusted_Connection=True;");
            //Conexion a la base de datos (aca podes tener mas de 1)
        }
        protected override void OnModelCreating(ModelBuilder Modelos)
        {
            new SttAlq(Modelos.Entity<Alquileres>());
            new SttCliente(Modelos.Entity<Cliente>());
            new SttE_D_A(Modelos.Entity<EstadoDeAlquileres>());
            new SttLibros(Modelos.Entity<Libros>());

            base.OnModelCreating(Modelos);
            //Conexion con los Modemos (Es decir donde pones q datos tiene las tablas)
        }
        public DbSet<Alquileres> alquileres { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<EstadoDeAlquileres> estadoDeAlquileres { get; set; }
        public DbSet<Libros> libros { get; set; }
        //Conexion a las tablas
    }


}
