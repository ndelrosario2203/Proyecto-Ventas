using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class RolMenu : BaseEntity
    {
        public int IdRolMenu { get; set; }
        public int? IdRol { get; set; }
        public int? IdMenu { get; set; }
    }
}
