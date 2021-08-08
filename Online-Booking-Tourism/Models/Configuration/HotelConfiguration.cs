using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Booking_Tourism.Models.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    HotelName = "Hilton",
                    Place = "colombo",
                    AcNoneac = true,
                    Price = 5000
                },
                new Hotel
                {
                    Id = 2,
                    HotelName = "Sandrilla",
                    Place = "colombo",
                    AcNoneac = true,
                    Price = 6000
                }
            );
        }
    }
}
