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
    public class CategoriaDb : ICategoriaDb
    {
        public bool Exists(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categoria GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
