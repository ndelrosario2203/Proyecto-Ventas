using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class NegocioDb : DaoBase<Negocio>, INegocioDB
    {
        private readonly DbContext context;
        private readonly ILogger<Negocio> logger;

        public NegocioDb(VentasContext context, ILogger<Negocio> logger) : base(context)
        {
             this.context = context;

             this.logger = logger;
        }
    }
}
