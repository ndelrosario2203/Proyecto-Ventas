using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class Rol : BaseEntity
    {
        public int IdRol { get; set; }
        public string? Descripcion { get; set; }
    }
}
