using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public int IdMenu { get; set; }
        public string? Descripcion { get; set; }
        public int? IdMenuPadre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }

    }
}
