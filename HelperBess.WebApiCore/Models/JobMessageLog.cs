using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class JobMessageLog
    {
        public int JobMessageLogId { get; set; }
        public int? JobAssignmentId { get; set; }
        public int? MessageType { get; set; }
        public DateTime? MessageDateTime { get; set; }
        public string Message { get; set; }

        public virtual JobAssignment JobAssignment { get; set; }
    }
}
