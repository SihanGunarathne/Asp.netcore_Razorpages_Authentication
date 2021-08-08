using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Booking_Tourism.Models
{
    public class Guider
    {
        public int Id { get; set; }
        public string GuiderName { get; set; }
        public string Place { get; set; }
        public string TelephoneNumber { get; set; }
        public int Price { get; set; }
    }
}
