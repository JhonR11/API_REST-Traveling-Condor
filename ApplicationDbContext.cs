using API_RESTCV.ENTITY;
using API_RESTCV.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace API_RESTCV
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedingInicial.Seed(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Ruta> Rutas => Set<Ruta>();
        public DbSet<PuntoDeInteres> PuntosdeInteres => Set<PuntoDeInteres>();

    }
}
