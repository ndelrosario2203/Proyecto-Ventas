using Ventas.AppService.Core;

namespace Ventas.AppService.Contracts
{
    public interface INegocioService
    {
        ServiceResult GetNegocioById(int negocioId);
        ServiceResult GetNegocioByDates(DateTime startDate, DateTime endDate);
        ServiceResult GetNegocioCount();
    }
}
