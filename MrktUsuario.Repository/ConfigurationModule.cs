using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MrktUsuario.Domain.Repository;
using MrktUsuario.Repository.Context;
using MrktUsuario.Repository.Database;
using MrktUsuario.Repository.Repository;

namespace MrktUsuario.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MrktUsuarioContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
