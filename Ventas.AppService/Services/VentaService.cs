using System;
using Microsoft.Extensions.Logging;
using Ventas.AppService.Contracts;
using Ventas.AppService.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.AppService.Services
{
    public class VentaService : IVentaService
    {
        private readonly IVentaDB ventaDB;
        private readonly ILogger<VentaService> logger;

        public VentaService(IVentaDB ventaDB, ILogger<VentaService> logger)
        {
            this.ventaDB = ventaDB;
            this.logger = logger;
        }

        public ServiceResult GetVentasByDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        //public ServiceResult GetVentasByDates(DateTime startDate, DateTime endDate)
        //{
        //    ServiceResult result = new ServiceResult();

        //    try
        //    { 
        //        result.Data = this.ventaDB.get
        //    }

        //}

        public ServiceResult GetVentasById(int ventaId)
        {
            ServiceResult result = new ServiceResult();

            try
            {

                result.Data = this.ventaDB.GetById(ventaId);

            }

            catch (Exception ex) {
            
                result.Success = false;
                result.Message = "Error obteniendo los datos";
                this.logger.LogError(ex, result.Message);
            }

            return result;
        }

        public ServiceResult GetVentasCount()
        {
            ServiceResult result = new ServiceResult();

            try
            {

                result.Data = this.ventaDB.GetAll();

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
