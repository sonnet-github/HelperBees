using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperBess.WebApiCore.Models
{
    public partial class JobMessageLogGet
    {
        public int JobMessageLogId { get; set; }
        public int JobAssignmentId { get; set; }
        public int? MessageType { get; set; }
        public DateTime? MessageDateTime { get; set; }
        public string Message { get; set; }

        public JobAssignmentGet JobAssignmentGet { get; set; }
    }

    public partial class JobAssignmentGet
    {
        
        public int JobAssignmentId { get; set; }
        public int? ParticipantID { get; set; }
        public int? JobId { get; set; }
        public int? SupportWorkerId { get; set; }

    }



}
