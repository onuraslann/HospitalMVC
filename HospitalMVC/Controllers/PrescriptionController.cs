using HospitalMVC.Models.EntityFramework;
using HospitalMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    public class PrescriptionController : Controller
    {
        HospitalDBEntities db = new HospitalDBEntities();
        public ActionResult Index()
        {
            var model = db.Prescriptions.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            var model = new PrescriptionViewModel()
            {
                 Doctors=db.Doctors.ToList()

            };
            return View("Yeni", model);
        }
        public ActionResult Kaydet(Prescriptions prescriptions)
        {
            if (prescriptions.Id == 0)
            {
                db.Prescriptions.Add(prescriptions);
            }
            else
            {
                var entityModel = db.Entry(prescriptions);
                entityModel.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new PrescriptionViewModel()
            {
                Doctors = db.Doctors.ToList(),
                Prescriptions = db.Prescriptions.Find(id)

            };
            return View("Yeni", model);

        }
        public ActionResult Delete(int id)
        {
            var deletedModel = db.Prescriptions.Find(id);
            if (deletedModel == null)
            {
                return HttpNotFound();
            }
            db.Prescriptions.Remove(deletedModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}