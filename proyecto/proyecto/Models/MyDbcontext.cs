using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace proyecto.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(cliente => cliente.idCliente);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(pelicula => pelicula.idPelicula);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alquiler>().HasKey(alquiler => alquiler.idAlquiler);
        }
        public DbSet<proyecto.Models.Pelicula> Pelicula { get; set; } = default!;
        public DbSet<proyecto.Models.Alquiler> Alquiler { get; set; } = default!;
    }
}
