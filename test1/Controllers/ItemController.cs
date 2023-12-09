using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.Models;

namespace test1.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            List<Itemlist> itemlist = new List<Itemlist>()
            {
                new Itemlist{Id ="001",Name="Bynn",Price=500,Category="laptop"},
                new Itemlist{Id ="002",Name="dds",Price=600,Category="laptop"},
                new Itemlist{Id ="003",Name="sd",Price=700,Category="laptop"},

            };
            itemlist.Add(new Itemlist { Id = "004", Name = "Msi", Price = 900, Category = "laptop" });
            return View(itemlist);
        }
    }
}