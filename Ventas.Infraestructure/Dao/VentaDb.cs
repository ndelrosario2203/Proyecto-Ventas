using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class VentaDb : IVentaDB
    {
        public bool Exists(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Venta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Venta GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Venta entity)
        {
            throw new NotImplementedException();
        }
    }
}
