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
        [HttpPost]
        public int add() {
            int a = 1;
            int b = 4;
            int r = a+ b;
            return r;
        
        }
        [ActionName("text")]
        public ActionResult Show()
        {
            return File(Server.MapPath("~/Content/text.txt"), "text/plain");
        }
        public ActionResult Download()
        {
            return File(Server.MapPath("~/Content/text.txt"), "text/plain", "MVC5.txt");
        }
    }
}