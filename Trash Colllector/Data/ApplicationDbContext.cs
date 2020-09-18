using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trash_Colllector.Models;

namespace Trash_Colllector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; } 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole {
                Name = "Customer",
                NormalizedName = "CUSTOMER", 
            });

            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Employee",
                NormalizedName = "EMPLOYEE",
            });
        }
    }
}
