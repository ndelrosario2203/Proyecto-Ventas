//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ventas.ConceptualModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            this.Menu1 = new HashSet<Menu>();
            this.RolMenus = new HashSet<RolMenu>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdMenuPadre { get; set; }
        public string Icono { get; set; }
        public string Controlador { get; set; }
        public string PaginaAccion { get; set; }
        public Nullable<bool> EsActivo { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaMod { get; set; }
        public Nullable<int> IdUsuarioMod { get; set; }
        public Nullable<int> IdUsuarioElimino { get; set; }
        public Nullable<System.DateTime> FechaElimino { get; set; }
        public bool Eliminado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menu1 { get; set; }
        public virtual Menu Menu2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolMenu> RolMenus { get; set; }
    }
}
