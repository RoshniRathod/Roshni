using DAL.Domains.Base;
using DAL.Mappings;
using System.Collections.Generic;

namespace DAL.Domains
{
    public partial class Category : BaseEntity
    {
        public string Name { get; set; }
        public Category SubCategory { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<CategoryMedicine> CategoryMedicine { get; set; }
    }
}
