using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "Show Your Home Page";
            return View();
        }
        public ActionResult Showmore() 
        {

            return View("~/Views/About/Index.cshtml");
        }
        public int add() {
            int a = 1;
            int b = 4;
            int r = a+ b;
            return r;
        
        }
    }
}