using HospitalMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalMVC.ViewModels
{
    public class DoctorViewModel
    {
        public List<Departmans> Departmans { get; set; }
        public Doctors Doctors { get; set; }
    }
}