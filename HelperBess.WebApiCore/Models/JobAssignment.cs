﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class JobAssignment
    {
        public JobAssignment()
        {
            JobMessageLogs = new HashSet<JobMessageLog>();
        }

        public int JobAssignmentId { get; set; }
        public int? JobId { get; set; }
        public int? SupportWorkerId { get; set; }
        public bool? Alerts { get; set; }
        public DateTime? DateAssigned { get; set; }

        public virtual Job Job { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
        public virtual ICollection<JobMessageLog> JobMessageLogs { get; set; }
    }
}
