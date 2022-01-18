using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerQualification
    {
        public int SupportWorkerQualificationId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? QualificationId { get; set; }
        public string Certificate { get; set; }
        public DateTime? AcquiredDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? ExperienceYears { get; set; }
        public bool? ConfirmBoardRequirements { get; set; }
        public bool? ConfirmNoBoardComplaints { get; set; }
        public string ComplaintDetails { get; set; }

        public virtual SwQualification Qualification { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
