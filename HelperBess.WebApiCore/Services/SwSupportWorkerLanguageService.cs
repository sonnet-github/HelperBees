using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerLanguageService : ISwSupportWorkerLanguageService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerLanguageService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerLanguage AddSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage)
        {
            if (SwSupportWorkerLanguage != null)
            {
                dbContext.SwSupportWorkerLanguages.Add(SwSupportWorkerLanguage);
                dbContext.SaveChanges();
                return SwSupportWorkerLanguage;
            }
            return null;
        }

        public SwSupportWorkerLanguage DeleteSwSupportWorkerLanguage(int id)
        {
            var SwSupportWorkerLanguages = dbContext.SwSupportWorkerLanguages.FirstOrDefault(x => x.SupportWorkerLanguageId == id);
            dbContext.Entry(SwSupportWorkerLanguages).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerLanguages;
        }

        public IEnumerable<SwSupportWorkerLanguage> GetSwSupportWorkerLanguage()
        {
            var SwSupportWorkerLanguages = dbContext.SwSupportWorkerLanguages.ToList();
            return SwSupportWorkerLanguages;
        }

        public SwSupportWorkerLanguage GetSwSupportWorkerLanguageById(int id)
        {
            var SwSupportWorkerLanguages = dbContext.SwSupportWorkerLanguages.FirstOrDefault(x => x.SupportWorkerLanguageId == id);
            return SwSupportWorkerLanguages;
        }

        public SwSupportWorkerLanguage UpdateSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguages)
        {
            dbContext.Entry(SwSupportWorkerLanguages).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerLanguages;
        }

        public IEnumerable<SwSupportWorkerLanguage> GetSwSupportWorkerLanguageBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerLanguages = dbContext.SwSupportWorkerLanguages.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerLanguages;
        }
    }
}
