using DAL.Domains.Base;
using System.Collections.Generic;

namespace DAL.Domains
{
    public partial class Cart : BaseEntity
    {
        public int CustomerId { get; set; }
        public int ShoppingCartType { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Order Order { get; set; }
    }
}
