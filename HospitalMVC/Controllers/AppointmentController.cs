using HospitalMVC.Models.EntityFramework;
using HospitalMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    public class AppointmentController : Controller
    {

        HospitalDBEntities db = new HospitalDBEntities();
        public ActionResult Index()
        {
            var model = db.Appointments.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            var model = new AppointmentViewModel()
            {
                 Doctors=db.Doctors.ToList(),
                 Sicks=db.Sicks.ToList(),
                  Appointments=new Appointments()
            };
            return View("Yeni",model);
        }
        public ActionResult Kaydet(Appointments appointments)
        {
            if (!ModelState.IsValid)
            {
                var model = new AppointmentViewModel()
                {
                    Doctors = db.Doctors.ToList(),
                    Sicks = db.Sicks.ToList(),
                    Appointments = appointments
                };
                return View("Yeni", model);
            }
            if (appointments.Id == 0)
            {
                db.Appointments.Add(appointments);
            }
            else
            {
                var entityModel = db.Entry(appointments);
                entityModel.State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var model = new AppointmentViewModel()
            {
                Doctors = db.Doctors.ToList(),
                Sicks = db.Sicks.ToList(),
                Appointments=db.Appointments.Find(id)
            };
            return View("Yeni",model);
        }
        public ActionResult Delete(int id)
        {
            var deletedModel = db.Appointments.Find(id);
            if (deletedModel == null)
            {
                return HttpNotFound();
            }
            db.Appointments.Remove(deletedModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}