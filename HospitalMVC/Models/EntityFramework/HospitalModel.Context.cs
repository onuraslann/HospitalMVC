﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalDBEntities : DbContext
    {
        public HospitalDBEntities()
            : base("name=HospitalDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Departmans> Departmans { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Prescriptions> Prescriptions { get; set; }
        public virtual DbSet<Sicks> Sicks { get; set; }
        public virtual DbSet<Userss> Userss { get; set; }
    }
}
