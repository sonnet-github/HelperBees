#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantMedicationInformation
    {
        public int ParticipantMedicationInformationId { get; set; }
        public int? ParticipantId { get; set; }
        public string SupportWorkerInstructions { get; set; }
        public string CarePlan { get; set; }
        public string Gpdocuments { get; set; }
        public string OtherDocuments { get; set; }

        public virtual ClParticipant Participant { get; set; }
    }
}
