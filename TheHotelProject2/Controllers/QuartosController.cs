using System;
using System.IO;
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

        [HttpPost]
        public ActionResult Index(QuartosViewModel objQuartosViewModel)
        {
            string ImageUniqueName = Guid.NewGuid().ToString();
            string ImageUniqueNewName = ImageUniqueName + Path.GetExtension(objQuartosViewModel.Image.FileName);

            objQuartosViewModel.Image.SaveAs(Server.MapPath("~/ImageQuartos/" + ImageUniqueNewName));

            Quartos objQuarto = new Quartos()
            {
                QuartoNumero = objQuartosViewModel.QuartoNumero,
                QuartoDescricao = objQuartosViewModel.QuartoDescricao,
                QuartoPreco = objQuartosViewModel.QuartoPreco,
                QuartoCapacidade = objQuartosViewModel.QuartoCapacidade,
                ReservaStatusId = objQuartosViewModel.ReservaStatusId,
                QuartoDisponivel = true,
                QuartoFoto = ImageUniqueNewName,
                QuartoId = objQuartosViewModel.QuartoTipoID,

            };

            objHotelDBEntities.Quartos.Add(objQuarto);
            objHotelDBEntities.SaveChanges();

            return Json(data: new {message = "Quarto adicionado com sucesso!", success=true}, JsonRequestBehavior.AllowGet);
        }
    }
}