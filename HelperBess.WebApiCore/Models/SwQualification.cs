using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwQualification
    {
        public SwQualification()
        {
            SwSupportWorkerQualifications = new HashSet<SwSupportWorkerQualification>();
        }

        public int QualificationId { get; set; }
        public int? ServiceId { get; set; }
        public bool? ExperienceYears { get; set; }
        public bool? UploadRequired { get; set; }
        public bool? AcquiredDate { get; set; }
        public bool? ExpiryDate { get; set; }
        public bool? Ahrparequired { get; set; }
        public bool? BoardRequirements { get; set; }
        public bool? BoardComplaints { get; set; }
        public string BoardRequirementsName { get; set; }

        public virtual SwService Service { get; set; }
        public virtual ICollection<SwSupportWorkerQualification> SwSupportWorkerQualifications { get; set; }
    }
}
