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
    public class TipoDocumentoVentaDb : ITipoDocumentoVentaDb
    {
        public bool Exists(string Name)
        {
            throw new NotImplementedException();
        }

        public List<TipoDocumentoVenta> GetAll()
        {
            throw new NotImplementedException();
        }

        public TipoDocumentoVenta GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(TipoDocumentoVenta entity)
        {
            throw new NotImplementedException();
        }
    }
}
