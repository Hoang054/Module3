using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> Customers { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Ward> wards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser()
                {
                    Email = "xuanhoang054@gmail.com",
                    FullName = "Hoang Tran",
                    numberPhone = "0123456789",
                    Password = "Qwerty!23",
                    ConfirmPassword = "Qwerty!23",
                    idDistrict = 1,
                    idProvince = 2,
                    idWard = 3
                }
            );
        }
    }
}
