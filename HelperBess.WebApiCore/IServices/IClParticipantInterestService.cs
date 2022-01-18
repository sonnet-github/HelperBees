using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantInterestService
    {
        IEnumerable<ClParticipantInterest> GetClParticipantInterest();
        ClParticipantInterest GetClParticipantInterestById(int id);
        ClParticipantInterest AddClParticipantInterest(ClParticipantInterest ClParticipantInterest);
        ClParticipantInterest UpdateClParticipantInterest(ClParticipantInterest ClParticipantInterest);
        ClParticipantInterest DeleteClParticipantInterest(int id);
    }
}
