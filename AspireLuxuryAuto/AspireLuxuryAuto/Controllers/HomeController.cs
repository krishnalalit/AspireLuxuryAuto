using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspireLuxuryAuto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CarList()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CarListDetail()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Checkout()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewsDetails()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MakeReservation()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SelectCar()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChooseOptions()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Review()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}