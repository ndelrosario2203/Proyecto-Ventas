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
    
    public partial class RolMenu
    {
        public int Id { get; set; }
        public Nullable<int> IdRol { get; set; }
        public Nullable<int> IdMenu { get; set; }
        public Nullable<bool> EsActivo { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaMod { get; set; }
        public Nullable<int> IdUsuarioMod { get; set; }
        public Nullable<int> IdUsuarioElimino { get; set; }
        public Nullable<System.DateTime> FechaElimino { get; set; }
        public bool Eliminado { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
