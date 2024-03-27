using Ventas.Domain.Core;

namespace Ventas.Infraestructure.Core
{
    public interface IDaoBase<Tentity> where Tentity : class
    {
        Task<DataResult> Save(Tentity entity);
        Task<DataResult> Update(Tentity entity);
        Task<List<Tentity>> GetAll();
        Task<List<Tentity>> GetTentitiesWithFilters(Func<Tentity, bool> filter);
        Task<Tentity> GetById(int id);
        bool Exists(Func<Tentity, bool> filter);
        Task<int> Commit();
    }
}
