using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MustardClinic.Models
{
    public class Prescriptions
    {
        [Key]
        public int DrugID { get; set; }
        public string DrugName { get; set; }
        public string DrugDose { get; set; }

    }
}