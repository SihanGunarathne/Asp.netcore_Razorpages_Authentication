using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Online_Booking_Tourism.Models
{
    public class Traveler
    {
        public int Id { get; set; }
        [Required]
        public string TravellerName { get; set; }
        [Required]
        public string Place { get; set; }
        public string TelephoneNumber { get; set; }
        public string TravellingDate { get; set; }
    }
}
