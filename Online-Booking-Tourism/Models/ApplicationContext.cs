using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Online_Booking_Tourism.Models.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Online_Booking_Tourism.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new GuiderConfiguration());
            modelBuilder.ApplyConfiguration(new TravelerConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<Guider> Guiders { get; set; }
        public DbSet<Admin> Admins { get; set; }
 

       
    }
}

