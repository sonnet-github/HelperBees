using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwServiceGroup
    {
        public SwServiceGroup()
        {
            SwServices = new HashSet<SwService>();
            SwSupportWorkerOtherQualifications = new HashSet<SwSupportWorkerOtherQualification>();
        }

        public int ServiceGroupId { get; set; }
        public string ServiceGroup { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<SwService> SwServices { get; set; }
        public virtual ICollection<SwSupportWorkerOtherQualification> SwSupportWorkerOtherQualifications { get; set; }
    }
}
