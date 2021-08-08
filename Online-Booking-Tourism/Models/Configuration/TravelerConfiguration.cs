using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Booking_Tourism.Models.Configuration
{
    public class TravelerConfiguration : IEntityTypeConfiguration<Traveler>
    {
        public void Configure(EntityTypeBuilder<Traveler> builder)
        {
            builder.HasData(
                new Traveler
                {
                    Id = 1,
                    TravellerName = "Micheal warner",
                    Place = "colombo",
                    TelephoneNumber = "0710000000",
                    TravellingDate = "30/11/2020"
                },
                new Traveler
                {
                    Id = 2,
                    TravellerName = "Anne Boucher",
                    Place = "colombo",
                    TelephoneNumber = "0710000000",
                    TravellingDate = "30/11/2020"
                }
            );
        }
    }
}
