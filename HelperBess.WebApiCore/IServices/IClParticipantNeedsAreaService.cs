using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantNeedsAreaService
    {
        IEnumerable<ClParticipantNeedsArea> GetClParticipantNeedsArea();
        ClParticipantNeedsArea GetClParticipantNeedsAreaById(int id);
        ClParticipantNeedsArea AddClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsArea);
        ClParticipantNeedsArea UpdateClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsArea);
        ClParticipantNeedsArea DeleteClParticipantNeedsArea(int id);
    }
}
