using Online_Booking_Tourism.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Booking_Tourism.Models.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(
                new Admin
                {
                    Id = 1,
                    UserName = "Mark Simmon",
                    Password = 9876

                },
                new Admin
                {
                    Id = 2,
                    UserName = "Shane watson",
                    Password = 1234

                }
            );
        }
    }
}
