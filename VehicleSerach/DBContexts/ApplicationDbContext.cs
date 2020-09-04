using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleSerach.Models;

namespace VehicleSerach.DBContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Vehicle> vehicles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    id=1,
                    Vehicle_Number = "MH-11 SS-1234",
                    Vehicle_Type = "Car",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 2,
                    Vehicle_Number = "MH-12 SS-1234",
                    Vehicle_Type = "Bus",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 3,
                    Vehicle_Number = "MH-13 SS-1234",
                    Vehicle_Type = "Tempo",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 4,
                    Vehicle_Number = "MH-14 SS-1234",
                    Vehicle_Type = "Truck",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 5,
                    Vehicle_Number = "MH-15 SS-1234",
                    Vehicle_Type = "Bus",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 6,
                    Vehicle_Number = "MH-16 SS-1234",
                    Vehicle_Type = "Car",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 7,
                    Vehicle_Number = "MH-17 SS-1234",
                    Vehicle_Type = "Bus",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 8,
                    Vehicle_Number = "MH-18 SS-1234",
                    Vehicle_Type = "Car",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                },
                new Vehicle
                {
                    id = 9,
                    Vehicle_Number = "MH-19 SS-1234",
                    Vehicle_Type = "Car",
                    Chassis_Number = "13245",
                    Engine_Number = "1234",
                    Manufacturing_year = "2001",
                    Load_carrying_capacity = "500000",
                    Make_of_vehicle = "India",
                    Model_Number = "345",
                    Body_type = "New",
                    Organisation_name = "India",
                    DeviceID = "345",
                    UserID = "1",
                }




            );
        }
    }
}
