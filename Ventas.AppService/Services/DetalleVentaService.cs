using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ventas.AppService.Contracts;
using Ventas.AppService.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.AppService.Services
{
    public class DetalleVentaService : IDetalleVentaService
    {
        private readonly IDetalleVentaDB detalleVentaDB;
        private readonly ILogger<DetalleVentaService> logger;
        public ServiceResult GetDetalleVentaByDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetDetalleVentaById(int DetalleVentaId)
        {
            ServiceResult result = new ServiceResult();

            try
            {

                result.Data = this.detalleVentaDB.GetById(DetalleVentaId);

            }

            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }

            return result;
        }

        public ServiceResult GetDetalleVentaCount()
        {
            ServiceResult result = new ServiceResult();

            try
            {

                result.Data = this.detalleVentaDB.GetAll();

            }

            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }

            return result;
        }
    }
}
