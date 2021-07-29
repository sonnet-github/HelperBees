using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ScSupportCoordinator
    {
        public ScSupportCoordinator()
        {
            ScSupportCoordinatorProfiles = new HashSet<ScSupportCoordinatorProfile>();
            ScSupportCoordinatorSupportWorkers = new HashSet<ScSupportCoordinatorSupportWorker>();
            ScimpersonisationLoginAudits = new HashSet<ScimpersonisationLoginAudit>();
            ScloginAudits = new HashSet<ScloginAudit>();
        }

        public int SupportCoordinatorId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int? FailedLoginCount { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? StatusId { get; set; }
        public bool? Locked { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<ScSupportCoordinatorProfile> ScSupportCoordinatorProfiles { get; set; }
        public virtual ICollection<ScSupportCoordinatorSupportWorker> ScSupportCoordinatorSupportWorkers { get; set; }
        public virtual ICollection<ScimpersonisationLoginAudit> ScimpersonisationLoginAudits { get; set; }
        public virtual ICollection<ScloginAudit> ScloginAudits { get; set; }
    }
}
