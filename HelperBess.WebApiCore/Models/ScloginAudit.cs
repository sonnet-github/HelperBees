using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ScloginAudit
    {
        public int ScloginAuditId { get; set; }
        public int? SupportCoordinatorId { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? LoginSuccess { get; set; }

        public virtual ScSupportCoordinator SupportCoordinator { get; set; }
    }
}
