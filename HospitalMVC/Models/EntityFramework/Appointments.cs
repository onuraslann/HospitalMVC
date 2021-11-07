//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMVC.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Appointments
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }
        [Display(Name ="SickTC")]
        [Required(ErrorMessage ="Tc bo� ge�ilemez")]
        public Nullable<int> SickId { get; set; }
        [Display(Name = "SickName")]
        public Nullable<int> DoctorId { get; set; }
    
        public virtual Doctors Doctors { get; set; }
        public virtual Sicks Sicks { get; set; }
    }
}
