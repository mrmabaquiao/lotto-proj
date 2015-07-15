using LottoProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LottoProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILottoDataSource _db;

        public HomeController(ILottoDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDraws = _db.Draws;
            return View(allDraws);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
