using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ILanguageService
    {
        IEnumerable<Language> GetLanguage();
        Language GetLanguageById(int id);
        Language AddLanguage(Language Language);
        Language UpdateLanguage(Language Language);
        Language DeleteLanguage(int id);
    }
}
