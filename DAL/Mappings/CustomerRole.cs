using DAL.Domains;

namespace DAL.Mappings
{
    public partial class CustomerRole
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
