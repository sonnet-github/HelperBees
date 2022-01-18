using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerLanguageService
    {
        IEnumerable<SwSupportWorkerLanguage> GetSwSupportWorkerLanguage();
        SwSupportWorkerLanguage GetSwSupportWorkerLanguageById(int id);
        SwSupportWorkerLanguage AddSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage);
        SwSupportWorkerLanguage UpdateSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage);
        SwSupportWorkerLanguage DeleteSwSupportWorkerLanguage(int id);
    }
}
