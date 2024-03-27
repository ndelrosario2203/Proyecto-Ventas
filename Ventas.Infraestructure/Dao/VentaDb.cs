using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Ventas.Infraestructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace Ventas.Infraestructure.Dao
{
    public class VentaDb : DaoBase<Venta>, IVentaDB
    {
        private readonly DbContext context;
        private readonly ILogger<VentaDb> logger;

        public VentaDb(VentasContext context, ILogger<VentaDb> logger) : base(context)
        {
            this.context = context;

            this.logger = logger;   
        }


    }
}
