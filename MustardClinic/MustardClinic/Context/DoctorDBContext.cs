using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MustardClinic.Context
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }

    public class DoctorDBContext : DbContext
    {
        public DoctorDBContext()
        { }
        public DbSet<Doctor> Doctors { get; set; }
    }
}