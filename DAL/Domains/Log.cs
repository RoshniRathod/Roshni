using DAL.Domains.Base;
using System;

namespace DAL.Domains
{
    public partial class Log : BaseEntity
    {
        public int LogLevel { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
