using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Mobile_Number { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }
        public string Email_address { get; set; }
        public string Location { get; set; }
        public string Photopath { get; set; }

    }
}
