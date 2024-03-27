using Microsoft.Extensions.DependencyInjection;
using Ventas.AppService.Contracts;
using Ventas.AppService.Services;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.IOC.DetalleVentaDependencies
{
    public static class DetalleVentaDependency
    {
        public static void AddCourseDependency(this IServiceCollection services)
        {
            services.AddScoped<IVentaDB, VentaDb>();
            services.AddTransient<IVentaService, VentaService>();
        }
    }
}
