using DAL.Domains.Base;

namespace DAL.Domains
{
    public partial class Password : BaseEntity
    {
        public string PasswordString { get; set; }
        public string Salt { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
