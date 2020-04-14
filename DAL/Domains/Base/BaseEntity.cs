using System.ComponentModel.DataAnnotations;

namespace DAL.Domains.Base
{
    public partial class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
