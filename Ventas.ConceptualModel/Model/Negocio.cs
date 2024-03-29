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
    
    public partial class Negocio
    {
        public int Id { get; set; }
        public string UrlLogo { get; set; }
        public string NombreLogo { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Nullable<decimal> PorcentajeImpuesto { get; set; }
        public string SimboloMoneda { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaMod { get; set; }
        public Nullable<int> IdUsuarioMod { get; set; }
        public Nullable<int> IdUsuarioElimino { get; set; }
        public Nullable<System.DateTime> FechaElimino { get; set; }
        public bool Eliminado { get; set; }
    }
}
