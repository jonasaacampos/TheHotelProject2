using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheHotelProject2.Models;
using TheHotelProject2.ViewModel;
using System.Web.Mvc.Html;

namespace TheHotelProject2.Controllers
{
    public class QuartosController : Controller
    {

        HotelDBEntities objHotelDBEntities;

        public QuartosController()
        {
            objHotelDBEntities = new HotelDBEntities();
        }

        public ActionResult Index()
        {
            QuartosViewModel objQuartosViewModel = new QuartosViewModel();

            objQuartosViewModel.ListaReservaStatus = (from obj in objHotelDBEntities.ReservaStatus
                                                      select new SelectListItem()
                                                      {
                                                          Text = obj.ReservaStatus1,
                                                          Value = obj.ReservaStatusId.ToString()
                                                      }).ToList();


            objQuartosViewModel.ListaQuartoTipo = (from obj in objHotelDBEntities.QuartosTipo
                                                      select new SelectListItem()
                                                      {
                                                          Text = obj.QuartoTipo,
                                                          Value = obj.QuartoTipoID.ToString()
                                                      }).ToList();


            return View(objQuartosViewModel);
        }
    }
}