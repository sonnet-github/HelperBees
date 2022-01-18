using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwEducation
    {
        public int EducationId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string Institution { get; set; }
        public string DegreeCourse { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? StillCurrent { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
