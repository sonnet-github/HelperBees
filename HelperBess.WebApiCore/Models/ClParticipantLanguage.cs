#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantLanguage
    {
        public int ParticipantLanguageId { get; set; }
        public int? ParticipantId { get; set; }
        public int? LanguageId { get; set; }
        public string Type { get; set; }

        public virtual Language Language { get; set; }
        public virtual ClParticipant Participant { get; set; }
    }
}
