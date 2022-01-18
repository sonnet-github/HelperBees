using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantService
    {
        IEnumerable<ClParticipant> GetClParticipant();
        ClParticipant GetClParticipantById(int id);
        ClParticipant AddClParticipant(ClParticipant ClParticipant);
        ClParticipant UpdateClParticipant(ClParticipant ClParticipant);
        ClParticipant DeleteClParticipant(int id);
    }
}
