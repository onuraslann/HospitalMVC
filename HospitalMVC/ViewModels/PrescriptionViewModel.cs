using HospitalMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalMVC.ViewModels
{
    public class PrescriptionViewModel
    {
        public List<Doctors> Doctors { get; set; }

        public Prescriptions Prescriptions { get; set; }
    }
}