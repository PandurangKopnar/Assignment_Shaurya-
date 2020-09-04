using App1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.DBContexts
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {   
                    UserID=1,
                    Name = "Pandurang Kopnar",
                    Mobile_Number = "8422910044",
                    Organization = "-",
                    Address = "Pune",
                    Email_address = "pandurang.kopnar7@gmail.com",
                    Location = "Pune",
                    Photopath="-",
                }                
            );
        }
    }
}
