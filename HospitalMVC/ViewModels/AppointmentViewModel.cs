using HospitalMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalMVC.ViewModels
{
    public class AppointmentViewModel
    {
        public List<Doctors> Doctors { get; set; }
        public List<Sicks> Sicks { get; set; }
        public Appointments Appointments { get; set; }
    }
}