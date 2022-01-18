using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class LanguageService : ILanguageService
    {
        HelperBeesContext dbContext;
        public LanguageService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public Language AddLanguage(Language Language)
        {
            if (Language != null)
            {
                dbContext.Languages.Add(Language);
                dbContext.SaveChanges();
                return Language;
            }
            return null;
        }

        public Language DeleteLanguage(int id)
        {
            var Languages = dbContext.Languages.FirstOrDefault(x => x.LanguageId == id);
            dbContext.Entry(Languages).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return Languages;
        }

        public IEnumerable<Language> GetLanguage()
        {
            var Languages = dbContext.Languages.ToList();
            return Languages;
        }

        public Language GetLanguageById(int id)
        {
            var Languages = dbContext.Languages.FirstOrDefault(x => x.LanguageId == id);
            return Languages;
        }

        public Language UpdateLanguage(Language Languages)
        {
            dbContext.Entry(Languages).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Languages;
        }
    }
}
