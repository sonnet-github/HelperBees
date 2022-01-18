#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantReligion
    {
        public int ParticipantReligionId { get; set; }
        public int? ParticipantId { get; set; }
        public int? ReligionId { get; set; }

        public virtual ClParticipant Participant { get; set; }
        public virtual Religion Religion { get; set; }
    }
}
