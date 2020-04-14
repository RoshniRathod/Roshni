using DAL.Domains;

namespace DAL.Mappings
{
    public partial class CategoryMedicine
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}
