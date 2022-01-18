using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantLanguageService : IClParticipantLanguageService
    {
        HelperBeesContext dbContext;
        public ClParticipantLanguageService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantLanguage AddClParticipantLanguage(ClParticipantLanguage ClParticipantLanguage)
        {
            if (ClParticipantLanguage != null)
            {
                dbContext.ClParticipantLanguages.Add(ClParticipantLanguage);
                dbContext.SaveChanges();
                return ClParticipantLanguage;
            }
            return null;
        }

        public ClParticipantLanguage DeleteClParticipantLanguage(int id)
        {
            var ClParticipantLanguages = dbContext.ClParticipantLanguages.FirstOrDefault(x => x.ParticipantLanguageId == id);
            dbContext.Entry(ClParticipantLanguages).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantLanguages;
        }

        public IEnumerable<ClParticipantLanguage> GetClParticipantLanguage()
        {
            var ClParticipantLanguages = dbContext.ClParticipantLanguages.ToList();
            return ClParticipantLanguages;
        }

        public ClParticipantLanguage GetClParticipantLanguageById(int id)
        {
            var ClParticipantLanguages = dbContext.ClParticipantLanguages.FirstOrDefault(x => x.ParticipantLanguageId == id);
            return ClParticipantLanguages;
        }

        public ClParticipantLanguage UpdateClParticipantLanguage(ClParticipantLanguage ClParticipantLanguages)
        {
            dbContext.Entry(ClParticipantLanguages).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantLanguages;
        }
    }
}
