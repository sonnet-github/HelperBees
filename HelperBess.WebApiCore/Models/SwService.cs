using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwService
    {
        public SwService()
        {
            SwQualifications = new HashSet<SwQualification>();
            SwSupportWorkerServices = new HashSet<SwSupportWorkerService>();
        }

        public int ServiceId { get; set; }
        public int? ServiceGroupId { get; set; }
        public string Service { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual SwServiceGroup ServiceGroup { get; set; }
        public virtual ICollection<SwQualification> SwQualifications { get; set; }
        public virtual ICollection<SwSupportWorkerService> SwSupportWorkerServices { get; set; }
    }
}
