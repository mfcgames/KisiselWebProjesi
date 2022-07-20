using KisiselWebProjesi.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KisiselWebProjesi.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        Context context=new Context();
        
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var info = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.UserName, false);
                Session["UserName"] = info.UserName.ToString();
                return RedirectToAction("Index", "Admin");//Index
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}