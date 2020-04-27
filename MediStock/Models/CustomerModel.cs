using DAL.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediStockWeb.Models
{
    public class CustomerModel 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
        [DataType(DataType.Password)]
        public Password Password { get; set; }
        public Password confirmPassword { get; set; }
    }
}
