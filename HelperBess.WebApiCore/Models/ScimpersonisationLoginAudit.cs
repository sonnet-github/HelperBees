using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ScimpersonisationLoginAudit
    {
        public int ScimpLoginAuditId { get; set; }
        public int? SupportCoordinatorId { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual ScSupportCoordinator SupportCoordinator { get; set; }
    }
}
