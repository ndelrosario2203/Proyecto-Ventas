using Microsoft.Extensions.DependencyInjection;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;
using Ventas.AppService.Services;
using Ventas.AppService.Contracts;


namespace Ventas.IOC.VentaDependencies
{
    public static class VentaDependency
    {
        public static void AddCourseDependency(this IServiceCollection services)
        {
            services.AddScoped<IVentaDB, VentaDb>();
            services.AddTransient<IVentaService, VentaService>();
        }
    }
}
