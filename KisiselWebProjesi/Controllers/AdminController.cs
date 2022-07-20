using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var c = context.MainPages.ToList();
            return View(c);
        }
        public ActionResult BringToMainPage(int id)
        {
            var c =context.MainPages.Find(id);
            return View("BringToMainPage",c);
        }
        public ActionResult UpdateMainPage(MainPage mp)
        {
            var c =context.MainPages.Find(mp.ID);
            c.ID = mp.ID;
            c.NameSurname = mp.NameSurname;
            c.Title = mp.Title;
            c.Image = mp.Image;
            c.Description = mp.Description;
            c.Communication = mp.Communication;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}