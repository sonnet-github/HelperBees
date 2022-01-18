using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClloginAudit
    {
        public int ClloginAuditId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? LoginSuccess { get; set; }

        public virtual SwClient Client { get; set; }
    }
}
