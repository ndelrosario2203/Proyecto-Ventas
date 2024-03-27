
using Ventas.AppService.Core;

namespace Ventas.AppService.Contracts
{
    public interface IVentaService
    {
        ServiceResult GetVentasById(int ventaId);
        ServiceResult GetVentasByDates(DateTime startDate, DateTime endDate);
        ServiceResult GetVentasCount();
    }
}
