using MustardClinic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustardClinic.Context
{
    public class PrescriptionsDBContext : DbContext
    {
        public PrescriptionsDBContext() : base("Perscriptions")
        {
        }
        public DbSet<Prescriptions> Prescriptions { get; set; }
    }

    }
