using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantMedicationService
    {
        IEnumerable<ClParticipantMedication> GetClParticipantMedication();
        ClParticipantMedication GetClParticipantMedicationById(int id);
        ClParticipantMedication AddClParticipantMedication(ClParticipantMedication ClParticipantMedication);
        ClParticipantMedication UpdateClParticipantMedication(ClParticipantMedication ClParticipantMedication);
        ClParticipantMedication DeleteClParticipantMedication(int id);
    }
}
