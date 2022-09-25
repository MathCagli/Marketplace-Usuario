using Microsoft.EntityFrameworkCore;

namespace MrktUsuario.Repository.Context
{
    public class MrktUsuarioContext : DbContext
    {

        public MrktUsuarioContext(DbContextOptions<MrktUsuarioContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MrktUsuarioContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
