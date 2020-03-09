using MustardClinic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MustardClinic.Context
{
    public class NarcoticDBContext : DbContext
    {
        public NarcoticDBContext() : base("Narcotic")
        {
        }
        public DbSet<Narcotic> Narcotics { get; set; }
    }

    }
