using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Interfaces;

namespace Ventas.Infraestructure.Dao
{
    public class ProductoDb : IProductoDb
    {
        public Task<int> Commit()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Func<Producto, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<Producto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Producto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Producto>> GetTentitiesWithFilters(Func<Producto, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Save(Producto entity)
        {
            throw new NotImplementedException();
        }

        public Task<DataResult> Update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
