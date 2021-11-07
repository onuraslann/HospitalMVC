using HospitalMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    [Authorize(Roles = "admin,editor")]
    public class SickController : Controller
    {
        HospitalDBEntities db = new HospitalDBEntities();
        public ActionResult Index()
        {
            var model = db.Sicks.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            return View("Yeni",new Sicks());
        }
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Sicks sicks)
        {
            if (!ModelState.IsValid)
            {
                return View("Yeni");
            }
            if (sicks.Id == 0)
            {
                db.Sicks.Add(sicks);
            }
            else
            {
                var entityModel = db.Entry(sicks);
                entityModel.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var deletedModel = db.Sicks.Find(id);
            if (deletedModel == null)
            {
                return HttpNotFound();

            }
            db.Sicks.Remove(deletedModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var deletedModel = db.Sicks.Find(id);
            if (deletedModel == null)
            {
                return HttpNotFound();

            }
            return View("Yeni");
        }

    }
}