using DAL.Domains.Base;

namespace DAL.Domains
{
    public partial class Picture : BaseEntity
    {
        public string AbsolutePath { get; set; }
        public string RelativePath { get; set; }
        public Medicine Medicine { get; set; }
    }
}
