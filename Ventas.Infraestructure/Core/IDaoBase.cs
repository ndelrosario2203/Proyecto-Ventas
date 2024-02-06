using Ventas.Domain.Core;

namespace Ventas.Infraestructure.Core
{
    public interface IDaoBase<Tentity> where Tentity : BaseEntity
    {
        DataResult Save(Tentity entity);
        List<Tentity> GetAll();
        Tentity GetById(int id);
        bool Exists(string Name);

    }
}
