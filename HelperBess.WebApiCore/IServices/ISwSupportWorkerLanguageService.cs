using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerLanguageService
    {
        IEnumerable<SwSupportWorkerLanguage> GetSwSupportWorkerLanguage();
        SwSupportWorkerLanguage GetSwSupportWorkerLanguageById(int id);

        IEnumerable<SwSupportWorkerLanguage> GetSwSupportWorkerLanguageBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerLanguage AddSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage);
        SwSupportWorkerLanguage UpdateSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage);
        SwSupportWorkerLanguage DeleteSwSupportWorkerLanguage(int id);
    }
}
