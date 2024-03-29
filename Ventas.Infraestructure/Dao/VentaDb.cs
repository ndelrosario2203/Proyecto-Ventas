using Ventas.Domain.Entities;
using Ventas.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Ventas.Infraestructure.Interfaces;
using Microsoft.Extensions.Logging;
using Ventas.Infraestructure.Model;

namespace Ventas.Infraestructure.Dao
{
    public class VentaDb : DaoBase<Venta>, IVentaDB
    {
        private readonly VentasContext context;
        private readonly ILogger<VentaDb> logger;

        public VentaDb(VentasContext context, ILogger<VentaDb> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }

        public List<VentaCount> ObtenerPorVendedor(int id)
        {
            List<VentaCount> VentaPorVendedor = new List<VentaCount>();

            try
            {
                VentaPorVendedor = (from user in context.Ventas
                                    join sale in context.Ventas
                                    on user.IdVenta equals sale.IdUsuario
                                    where user.Eliminado == false
                                    && sale.IdUsuario == id
                                    group user by user.IdUsuario
                               into myGroup
                                    orderby myGroup.Count() descending
                                    select new VentaCount()
                                    {
                                        nombreCliente = myGroup.FirstOrDefault().NombreCliente,
                                        count = myGroup.Count()
                                    }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return VentaPorVendedor;
        }
    }
}
