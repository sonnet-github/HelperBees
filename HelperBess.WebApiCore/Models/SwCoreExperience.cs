using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwCoreExperience
    {
        public SwCoreExperience()
        {
            SwSupportWorkerCoreExperiences = new HashSet<SwSupportWorkerCoreExperience>();
        }

        public int CoreExperienceId { get; set; }
        public int? CoreExperienceFieldId { get; set; }
        public string CoreExperienceName { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual SwCoreExperienceField CoreExperienceField { get; set; }
        public virtual ICollection<SwSupportWorkerCoreExperience> SwSupportWorkerCoreExperiences { get; set; }
    }
}
