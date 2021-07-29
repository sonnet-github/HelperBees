using System;
using System.Collections.Generic;

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

        public virtual ClParticipant Participant { get; set; }
    }
}
