using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduShop_Unsecure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult ProductPartial()
        {
            return PartialView("_ProductPartial");
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult ProductPartial(string product)
        {
            return PartialView("_ProductPartial");
        }

        public ActionResult ProductInfo()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Sidebar()
        {
            return PartialView("_Sidebar");
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult Sidebar(string Category)
        {
            return PartialView("_Sidebar");
        }

    }
}