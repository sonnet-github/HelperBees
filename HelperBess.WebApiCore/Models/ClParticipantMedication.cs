#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantMedication
    {
        public int ParticipantMedicationId { get; set; }
        public int? ParticipantId { get; set; }
        public string Description { get; set; }
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string ReasonTaken { get; set; }
        public string TypeofCare { get; set; }
        public string TypeofCareOther { get; set; }
        public string ReasonforCare { get; set; }
        public string MedicalHistory { get; set; }
        public bool? Allergies { get; set; }
        public string AllergyDetail { get; set; }
        public string MedicalCondi { get; set; }
        public string MedicalCondiOther { get; set; }
        public string MobilityIssues { get; set; }
        public string MedAssistance { get; set; }
        public virtual ClParticipant Participant { get; set; }
    }
}
