using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class TipoDocumentoVentaDb : ITipoDocumentoVentaDb
    {
        public Task<int> Commit()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Func<TipoDocumentoVenta, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<TipoDocumentoVenta>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TipoDocumentoVenta> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TipoDocumentoVenta>> GetTentitiesWithFilters(Func<TipoDocumentoVenta, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Save(TipoDocumentoVenta entity)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Update(TipoDocumentoVenta entity)
        {
            throw new NotImplementedException();
        }
    }
}
