using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class UsuarioDb : IUsuarioDb
    {
        public Task<int> Commit()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Func<Usuario, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetTentitiesWithFilters(Func<Usuario, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Save(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
