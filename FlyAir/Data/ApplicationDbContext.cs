using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FlyAir.Models.FlightModels;
using FlyAir.Models.StaffModels;

namespace FlyAir.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FlyAir.Models.FlightModels.Flight> Flight { get; set; }
        public DbSet<FlyAir.Models.FlightModels.Plane> Plane { get; set; }
        public DbSet<FlyAir.Models.StaffModels.Staff> Staff { get; set; }
        public DbSet<FlyAir.Models.StaffModels.Pilot> Pilot { get; set; }
        public DbSet<FlyAir.Models.StaffModels.Steward> Steward { get; set; }
    }
}
