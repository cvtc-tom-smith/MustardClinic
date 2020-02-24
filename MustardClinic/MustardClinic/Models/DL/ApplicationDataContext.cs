using MustardClinic.Models.IdentityModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MustardClinic.Models.DL
{
    public class DBModel : IdentityDbContext<ApplicationUser>
    {
        public DBModel()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static DBModel Create()
        {
            return new DBModel();
        }
    }
}