

using Ventas.AppService.Core;

namespace Ventas.AppService.Contracts
{
    public interface IDetalleVentaService
    {
        ServiceResult GetDetalleVentaById(int DetalleVentaId);
        ServiceResult GetDetalleVentaByDates(DateTime startDate, DateTime endDate);
        ServiceResult GetDetalleVentaCount();
    }
}
