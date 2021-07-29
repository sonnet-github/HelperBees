using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwClient
    {
        public SwClient()
        {
            ClloginAudits = new HashSet<ClloginAudit>();
        }

        public int ClientId { get; set; }
        public int SupportWorkerId { get; set; }
        public string Status { get; set; }
        public string DateAdded { get; set; }
        public string Notes { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
        public virtual ICollection<ClloginAudit> ClloginAudits { get; set; }
    }
}
