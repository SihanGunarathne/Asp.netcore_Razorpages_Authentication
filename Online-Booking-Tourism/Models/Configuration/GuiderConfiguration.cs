using Online_Booking_Tourism.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Booking_Tourism.Models.Configuration
{
    public class GuiderConfiguration : IEntityTypeConfiguration<Guider>
    {
        public void Configure(EntityTypeBuilder<Guider> builder)
        {
            builder.HasData(
                new Guider
                {
                    Id = 1,
                    GuiderName = "David Alan ",
                    Place = "colombo",
                    TelephoneNumber = "0710000000",
                    Price = 5000
                },
                new Guider
                {
                    Id = 2,
                    GuiderName = "Anna starc",
                    Place = "colombo",
                    TelephoneNumber = "0710000002",
                    Price = 6000
                }
            );
        }
    }
}
