using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();

        [Authorize]
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
        public ActionResult IconList()
        {
            var c = context.Icons.ToList();
            return View(c);
        }
        [HttpGet]
        public ActionResult AddIcon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddIcon(Icons p)
        {
            context.Icons.Add(p);
            context.SaveChanges();
            return RedirectToAction("IconList");
        }
        public ActionResult RemoveIcon(int id)
        {
            var icon=context.Icons.Find(id);
            context.Icons.Remove(icon);
            context.SaveChanges();
            return RedirectToAction("IconList");
        }
        public ActionResult EditIcon(int id)
        {
            var icon=context.Icons.Find(id);
            return View("EditIcon",icon);
        }
        public ActionResult UpdateIcon(Icons x)
        {
            var icon = context.Icons.Find(x.ID);
            icon.IconName = x.IconName;
            icon.Link=x.Link;
            context.SaveChanges();
            return RedirectToAction("IconList");
        }
    }
}