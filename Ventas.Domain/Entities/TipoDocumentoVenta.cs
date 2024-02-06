using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class TipoDocumentoVenta : BaseEntity
    {
        public int IdTipo { get; set; }
        public string? Descripcion { get; set; }

    }
}
