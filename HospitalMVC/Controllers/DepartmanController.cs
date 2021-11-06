using HospitalMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    public class DepartmanController : Controller
    {
        HospitalDBEntities db = new HospitalDBEntities();
        // GET: Departman
        public ActionResult Index()
        {
            var model = db.Departmans.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            return View("Yeni");
        }
        public ActionResult Kaydet(Departmans departmans)
        {
            if (departmans.Id == 0)
            {
                db.Departmans.Add(departmans);
            }
            else
            {
                var entityModel = db.Entry(departmans);
                entityModel.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var updatedModel = db.Departmans.Find(id);

            if (updatedModel == null)
            {
                return HttpNotFound();
            }
            db.SaveChanges();
            return View("Yeni");
        }
        public ActionResult Delete(int id)
        {
            var deletedModel = db.Departmans.Find(id);

            if (deletedModel == null)
            {
                return HttpNotFound();
            }
            db.Departmans.Remove(deletedModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}