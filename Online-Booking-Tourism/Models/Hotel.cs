using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Online_Booking_Tourism.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required]
        public string HotelName { get; set; }
        [Required]
        public string Place { get; set; }
        public bool AcNoneac { get; set; }
        public int Price { get; set; }
    }
}
