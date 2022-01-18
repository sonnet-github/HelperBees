using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantCulturalBackgroundService
    {
        IEnumerable<ClParticipantCulturalBackground> GetClParticipantCulturalBackground();
        ClParticipantCulturalBackground GetClParticipantCulturalBackgroundById(int id);
        ClParticipantCulturalBackground AddClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackground);
        ClParticipantCulturalBackground UpdateClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackground);
        ClParticipantCulturalBackground DeleteClParticipantCulturalBackground(int id);
    }
}
