using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DonglesAreGreat.Core;
using DonglesAreGreat.Core.Repositories;

namespace DonglesAreGreatWeb.Controllers
{
    public class HomeController : Controller
    {
        private IDongleRepository _dongleRepository;

        public HomeController(IDongleRepository dongleRepository)
        {
            _dongleRepository = dongleRepository;
        }

        public ActionResult Index()
        {
            var d = _dongleRepository.GetDongle();
            return View(d);
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
    }
}