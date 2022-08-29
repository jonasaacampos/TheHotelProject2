using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheHotelProject2.ViewModel
{
    public class QuartosViewModel
    {

        public int QuartoId { get; set; }
        public int QuartoNumero { get; set; }
        public string QuartoFoto { get; set; }
        public decimal QuartoPreco { get; set; }
        public int ReservaStatusId { get; set; }
        public int QuartoTipoID { get; set; }
        public int QuartoCapacidade { get; set; }
        public string QuartoDescricao { get; set; }

        public HttpPostedFileBase Image { get; set; }

        public List<SelectListItem> ListaReservaStatus { get; set; }

        public List<SelectListItem> ListaQuartoTipo { get; set; }

    }
}