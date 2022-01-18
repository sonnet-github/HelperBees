#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantCulturalBackground
    {
        public int ParticipantCulturalBackgroundId { get; set; }
        public int? ParticipantId { get; set; }
        public int? CulturalBackgroundId { get; set; }

        public virtual CulturalBackground CulturalBackground { get; set; }
        public virtual ClParticipant Participant { get; set; }
    }
}
