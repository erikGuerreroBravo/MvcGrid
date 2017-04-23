using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGridModel;
using System.Data.Linq;

namespace WebMvcGrid.Controllers
{
    public class HomeController : Controller
    {
        DCGlobalDataContext contexto = new DCGlobalDataContext();        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Modificando el ViewBag de la App";
            var result = contexto.SegUsuarios.ToList<SegUsuario>();
            return View(result);
        }
    }
}