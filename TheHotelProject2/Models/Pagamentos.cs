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
    
    public partial class Pagamentos
    {
        public int PagamentoId { get; set; }
        public int ReservaId { get; set; }
        public int PagamentoTipoId { get; set; }
        public decimal PagamentoValor { get; set; }
        public bool IsActive { get; set; }
    }
}
