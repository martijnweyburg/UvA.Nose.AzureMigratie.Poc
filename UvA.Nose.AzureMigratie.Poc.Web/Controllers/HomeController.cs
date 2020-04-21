using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UvA.Nose.AzureMigratie.Poc.Data.Interfaces;

namespace UvA.Nose.AzureMigratie.Poc.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPocService pocService;

        public HomeController(IPocService pocService)
        {
            this.pocService = pocService ?? throw new ArgumentNullException($"pocService is null");
        }

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
    }
}