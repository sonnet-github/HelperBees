using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwloginAudit
    {
        public int SwloginAuditId { get; set; }
        public int? SupportWorkerId { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? LoginSuccess { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
