using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantNeedService
    {
        IEnumerable<ClParticipantNeed> GetClParticipantNeed();
        ClParticipantNeed GetClParticipantNeedById(int id);
        ClParticipantNeed AddClParticipantNeed(ClParticipantNeed ClParticipantNeed);
        ClParticipantNeed UpdateClParticipantNeed(ClParticipantNeed ClParticipantNeed);
        ClParticipantNeed DeleteClParticipantNeed(int id);
    }
}
