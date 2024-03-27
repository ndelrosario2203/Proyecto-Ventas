using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ventas.AppService.Contracts;
using Ventas.AppService.Core;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.AppService.Services
{
    public class NegocioService : INegocioService
    {
        private readonly INegocioDB negocioDB;
        private readonly ILogger<NegocioService> logger;
        public ServiceResult GetNegocioByDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetNegocioById(int negocioId)
        {
            ServiceResult result = new ServiceResult();

            try
            {

                result.Data = this.negocioDB.GetById(negocioId);

            }

            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }

            return result;
        }

        public ServiceResult GetNegocioCount()
        {
            ServiceResult result = new ServiceResult();

            try
            {

                result.Data = this.negocioDB.GetAll();

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
