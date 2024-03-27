using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class DetalleVentaDB : DaoBase<DetalleVenta>, IDetalleVentaDB
    {
        private readonly DbContext context;
        private readonly ILogger<DetalleVenta> logger;

        public DetalleVentaDB(VentasContext context, ILogger<DetalleVenta> logger) : base(context)
        {
            this.context = context;

            this.logger = logger;
        }
    }
}
