using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class Job
    {
        public Job()
        {
            JobAssignments = new HashSet<JobAssignment>();
            JobTimes = new HashSet<JobTime>();
        }

        public int JobId { get; set; }
        public int? ParticipantId { get; set; }
        public string Suburb { get; set; }
        public string ParticipantDescription { get; set; }
        public string SupportWorkDescription { get; set; }
        public string GenderPreference { get; set; }
        public string TypeOfJob { get; set; }
        public string JobDetails { get; set; }
        public string Hours { get; set; }

        public virtual ClParticipant Participant { get; set; }
        public virtual ICollection<JobAssignment> JobAssignments { get; set; }
        public virtual ICollection<JobTime> JobTimes { get; set; }
    }
}
