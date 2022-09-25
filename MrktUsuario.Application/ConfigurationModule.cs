using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MrktUsuario.Application.Service;

namespace MrktUsuario.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);
            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
