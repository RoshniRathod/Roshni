using DAL.Domains.Base;

namespace DAL.Domains
{
    public partial class OrderItem : BaseEntity
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Cart Cart { get; set; }
    }
}
