using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        Context context = new Context();
        public ActionResult Index()
        {
            var c = context.MainPages.ToList();
            return View(c);
        }
        public PartialViewResult Icons()
        {
            var c=context.Icons.ToList();
            return PartialView(c);
        }
    }
}