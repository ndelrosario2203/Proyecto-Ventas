using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public int IdCategoria { get; set; }
        public string? Descripcion { get; set; }
    }
}
