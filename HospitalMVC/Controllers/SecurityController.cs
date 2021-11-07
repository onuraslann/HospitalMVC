using HospitalMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HospitalMVC.Controllers
{
    public class SecurityController : Controller
    {
        HospitalDBEntities db = new HospitalDBEntities();
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Userss userss)
        {
            var user = db.Userss.FirstOrDefault(x => x.Name == userss.Name && x.Password == userss.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Name, false);
                return RedirectToAction("Index", "Departman");

            }
            else
            {
                ViewBag.Mesaj = "Geçersiz kullanıcı ve şifre";
                return View();
            }
            
                 
        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}