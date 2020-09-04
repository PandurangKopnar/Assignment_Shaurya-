using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleSerach.Models
{
    public class Vehicle
    {
        public int id { get; set; }
        public string Vehicle_Number { get; set; }
        public string Vehicle_Type { get; set; }
        public string Chassis_Number { get; set; }
        public string Engine_Number { get; set; }
        public string Manufacturing_year { get; set; }
        public string Load_carrying_capacity { get; set; }
        public string Make_of_vehicle { get; set; }
        public string Model_Number { get; set; }
        public string Body_type { get; set; }
        public string Organisation_name { get; set; }
        public string DeviceID { get; set; }
        public string UserID { get; set; }
    }
}
