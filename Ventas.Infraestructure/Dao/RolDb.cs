using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class RolDb : IRolDb
    {
        public Task<int> Commit()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Func<Rol, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<Rol>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Rol> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Rol>> GetTentitiesWithFilters(Func<Rol, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Save(Rol entity)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Update(Rol entity)
        {
            throw new NotImplementedException();
        }
    }
}
