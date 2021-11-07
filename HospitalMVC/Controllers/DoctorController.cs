using HospitalMVC.Models.EntityFramework;
using HospitalMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    public class DoctorController : Controller
    {

        HospitalDBEntities db = new HospitalDBEntities();
    
        public ActionResult Index()
        {
            var model = db.Doctors.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            var model = new DoctorViewModel()
            {
                 Departmans=db.Departmans.ToList(),
                  Doctors=new Doctors()

            };
            return View("Yeni",model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Doctors doctors)
        {
            if (!ModelState.IsValid)
            {
                var model = new DoctorViewModel()
                {
                    Departmans = db.Departmans.ToList(),
                    Doctors = doctors

                };
                return View("Yeni", model);
            }
            if (doctors.Id == 0)
            {
                db.Doctors.Add(doctors);
            }
            else
            {
                var entityModel = db.Entry(doctors);
                entityModel.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new DoctorViewModel()
            {
                Departmans = db.Departmans.ToList(),
                 Doctors=db.Doctors.Find(id)

            };
            return View("Yeni", model);
        }
        public ActionResult Delete(int id)
        {
            var deletedModel = db.Doctors.Find(id);

            if (deletedModel == null)
            {
                return HttpNotFound();
            }
            db.Doctors.Remove(deletedModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}