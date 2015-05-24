using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodellicaTelerikMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Codellica Telerik MVC Series!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "www.codellica.net";

            return View();
        }

    }
}
