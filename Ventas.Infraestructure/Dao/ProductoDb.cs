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
        public bool Exists(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Producto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
