//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheHotelProject2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quartos
    {
        public int QuartoId { get; set; }
        public string QuartoNumero { get; set; }
        public string QuartoFoto { get; set; }
        public decimal QuartoPreco { get; set; }
        public int ReservaStatusId { get; set; }
        public int QuartoTipoID { get; set; }
        public int QuartoCapacidade { get; set; }
        public string QuartoDescricao { get; set; }
        public Nullable<bool> QuartoDisponivel { get; set; }

    }
}
