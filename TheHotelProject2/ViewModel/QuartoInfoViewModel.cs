using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheHotelProject2.ViewModel
{
    public class QuartoInfoViewModel
    {
        public int QuartoId { get; set; }
        
        public string QuartoNumero { get; set; }
       
        public string QuartoFoto { get; set; }

        public decimal QuartoPreco { get; set; }
    
        public string ReservaStatus { get; set; }

        public string QuartoTipo { get; set; }
    
        public int QuartoCapacidade { get; set; }

        public string QuartoDescricao { get; set; }

    }
}