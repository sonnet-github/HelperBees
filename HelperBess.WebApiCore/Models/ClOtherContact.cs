#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClOtherContact
    {
        public int OtherContactId { get; set; }
        public int? ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Relationship { get; set; }

        public virtual ClParticipant Participant { get; set; }
    }
}
