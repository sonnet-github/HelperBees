using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwCoreExperienceField
    {
        public SwCoreExperienceField()
        {
            SwCoreExperiences = new HashSet<SwCoreExperience>();
        }

        public int CoreExperienceFieldId { get; set; }
        public string CoreExperienceFieldName { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<SwCoreExperience> SwCoreExperiences { get; set; }
    }
}
