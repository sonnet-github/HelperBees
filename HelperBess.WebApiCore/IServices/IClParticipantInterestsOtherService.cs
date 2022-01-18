using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantInterestsOtherService
    {
        IEnumerable<ClParticipantInterestsOther> GetClParticipantInterestsOther();
        ClParticipantInterestsOther GetClParticipantInterestsOtherById(int id);
        ClParticipantInterestsOther AddClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOther);
        ClParticipantInterestsOther UpdateClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOther);
        ClParticipantInterestsOther DeleteClParticipantInterestsOther(int id);
    }
}
