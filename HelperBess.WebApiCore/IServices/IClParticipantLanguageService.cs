using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClParticipantLanguageService
    {
        IEnumerable<ClParticipantLanguage> GetClParticipantLanguage();
        ClParticipantLanguage GetClParticipantLanguageById(int id);
        ClParticipantLanguage AddClParticipantLanguage(ClParticipantLanguage ClParticipantLanguage);
        ClParticipantLanguage UpdateClParticipantLanguage(ClParticipantLanguage ClParticipantLanguage);
        ClParticipantLanguage DeleteClParticipantLanguage(int id);
    }
}
