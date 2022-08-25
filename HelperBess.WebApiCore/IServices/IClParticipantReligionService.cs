using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantReligionService
    {
        IEnumerable<ClParticipantReligion> GetClParticipantReligion();
        ClParticipantReligion GetClParticipantReligionById(int id);
        IEnumerable<ClParticipantReligion> GetClParticipantReligionByParticipantId(int participantid);
        ClParticipantReligion AddClParticipantReligion(ClParticipantReligion ClParticipantReligion);
        ClParticipantReligion UpdateClParticipantReligion(ClParticipantReligion ClParticipantReligion);
        ClParticipantReligion DeleteClParticipantReligion(int id);
    }
}
