using DAL.Domains.Base;
using DAL.Mappings;
using System;
using System.Collections.Generic;

namespace DAL.Domains
{
    public partial class Medicine : BaseEntity
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public Guid ProductGUID { get; set; }
        public decimal Price { get; set; }
        public int Manufacturer { get; set; }
        public string Description { get; set; }        
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Stock Stock { get; set; }
        public ICollection<CategoryMedicine> CategoryMedicine { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
