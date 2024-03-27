using Microsoft.Extensions.DependencyInjection;
using Ventas.AppService.Contracts;
using Ventas.AppService.Services;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.IOC.NegocioDependencies
{
    public static class NegocioDependency
    {
        public static void AddCourseDependency(this IServiceCollection services)
        {
            services.AddScoped<INegocioDB, NegocioDb>();
            services.AddTransient<INegocioService, NegocioService>();
        }
    }
}
