using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Show()
        {
            return File(Server.MapPath("~/Content/text.txt"),"text/plain");
        }
        public ActionResult showexternal()
        {
            return Redirect("https://facebook.com");
        }
    }
}