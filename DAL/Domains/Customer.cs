using DAL.Domains.Base;
using DAL.Mappings;
using System;
using System.Collections.Generic;

namespace DAL.Domains
{
    public partial class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Password Password { get; set; }
        public ICollection<CustomerRole> CustomerRoles { get; set; }
    }
}
