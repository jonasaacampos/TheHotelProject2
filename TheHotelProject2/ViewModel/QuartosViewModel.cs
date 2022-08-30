using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TheHotelProject2.ViewModel
{
    public class QuartosViewModel
    {

        public int QuartoId { get; set; }
        
        [Display(Name = "Nº do Quarto")]
        public string QuartoNumero { get; set; }

        [Display(Name = "Foto do Quarto")]
        public string QuartoFoto { get; set; }
        
        [Display(Name = "Valor da diária")]
        public decimal QuartoPreco { get; set; }

        [Display(Name = "Disponibilidade para reserva")]
        public int ReservaStatusId { get; set; }

        [Display(Name = "Tipo de Quarto")]
        public int QuartoTipoID { get; set; }

        [Display(Name = "Capacidade (nº de Pessoas)")]
        public int QuartoCapacidade { get; set; }

        [Display(Name = "Descrição")]
        public string QuartoDescricao { get; set; }

        public HttpPostedFileBase Image { get; set; }

        public List<SelectListItem> ListaReservaStatus { get; set; }

        public List<SelectListItem> ListaQuartoTipo { get; set; }

    }
}