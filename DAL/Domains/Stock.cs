using DAL.Domains.Base;

namespace DAL.Domains
{
    public partial class Stock : BaseEntity
    {
        public int Quantity { get; set; }
        public int LastStockQuantity { get; set; }
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}
