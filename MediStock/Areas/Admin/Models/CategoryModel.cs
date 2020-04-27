using System.ComponentModel.DataAnnotations;

namespace MediStockWeb.Areas.Admin.Models
{
    public partial class CategoryModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
