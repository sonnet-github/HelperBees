#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantInterest
    {
        public int ParticipantInterestsId { get; set; }
        public int? ParticipantId { get; set; }
        public int? InterestsId { get; set; }

        public virtual ClInterest Interests { get; set; }
        public virtual ClParticipant Participant { get; set; }
    }
}
