using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MustardClinic.Models
{
    public class UserDataEmp
    {
        [Key]
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string StateAbbrev { get; set; }
        public string ZipCode { get; set; }
    }
}