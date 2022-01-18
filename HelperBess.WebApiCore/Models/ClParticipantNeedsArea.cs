using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantNeedsArea
    {
        public ClParticipantNeedsArea()
        {
            ClParticipantNeeds = new HashSet<ClParticipantNeed>();
        }

        public int ParticipantNeedsAreaId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ClParticipantNeed> ClParticipantNeeds { get; set; }
    }
}
