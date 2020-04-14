using DAL.Domains.Base;
using DAL.Mappings;
using System.Collections.Generic;

namespace DAL.Domains
{
    public partial class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public ICollection<CustomerRole> CustomerRoles { get; set; }
    }
}
