using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MustardClinic.Models
{
    public class DoctorSchedule
    {
        [Key]
        public int DoctorId { get; set; }
        public string MondayAvailability { get; set; }
        public string TuesdayAvailability { get; set; }
        public string WednesdayAvailability { get; set; }
        public string ThursdayAvailability { get; set; }
        public string FridayAvailability { get; set; }
        public string SaturdayAvailability { get; set; }
        public string SundayAvailability { get; set; }
    }
}