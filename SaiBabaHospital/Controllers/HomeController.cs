using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaiBabaHospital.Controllers
{
    public class HomeController : Controller
    {
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


        public ActionResult Doctors()
        {
            return View();
        }

        public ActionResult Department()
        {
            return View();
        }

        public ActionResult Accommodation()
        {
            return View();
        }
        public ActionResult Career()
        {
            return View();
        }
        public ActionResult TPA()
        {
            return View();
        }

        public ActionResult Social()
        {
            return View();
        }

        public ActionResult Homemain()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

    }
}