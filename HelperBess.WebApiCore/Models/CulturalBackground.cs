using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class CulturalBackground
    {
        public CulturalBackground()
        {
            ClParticipantCulturalBackgrounds = new HashSet<ClParticipantCulturalBackground>();
            SwSupportWorkerCulturalBackgrounds = new HashSet<SwSupportWorkerCulturalBackground>();
        }

        public int CulturalBackgroundId { get; set; }
        public string CulturalBackground1 { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<ClParticipantCulturalBackground> ClParticipantCulturalBackgrounds { get; set; }
        public virtual ICollection<SwSupportWorkerCulturalBackground> SwSupportWorkerCulturalBackgrounds { get; set; }
    }
}
