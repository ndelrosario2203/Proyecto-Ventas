using Microsoft.EntityFrameworkCore;
using Ventas.Domain.Entities;

namespace Ventas.Infraestructure.Context
{
    public class VentasContext : DbContext
    { 
        public VentasContext(DbContextOptions<VentasContext> options) : base(options) { }

        #region "Dbset"

        public DbSet<Negocio>? Negocios { get; set; }
        public DbSet<Venta>? Ventas { get; set; }
        public DbSet<DetalleVenta>? DetalleVentas { get; set; }
        public DbSet<Producto>? productos { get; set; }
        public DbSet<Categoria>? categorias { get; set; }

        #endregion

    }
}
