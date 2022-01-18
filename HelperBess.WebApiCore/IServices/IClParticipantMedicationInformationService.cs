using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantMedicationInformationService
    {
        IEnumerable<ClParticipantMedicationInformation> GetClParticipantMedicationInformation();
        ClParticipantMedicationInformation GetClParticipantMedicationInformationById(int id);
        ClParticipantMedicationInformation AddClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformation);
        ClParticipantMedicationInformation UpdateClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformation);
        ClParticipantMedicationInformation DeleteClParticipantMedicationInformation(int id);
    }
}
