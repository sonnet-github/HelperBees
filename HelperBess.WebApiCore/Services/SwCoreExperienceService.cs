using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwCoreExperienceService : ISwCoreExperienceService
    {
        HelperBeesContext dbContext;
        public SwCoreExperienceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwCoreExperience AddSwCoreExperience(SwCoreExperience SwCoreExperience)
        {
            if (SwCoreExperience != null)
            {
                dbContext.SwCoreExperiences.Add(SwCoreExperience);
                dbContext.SaveChanges();
                return SwCoreExperience;
            }
            return null;
        }

        public SwCoreExperience DeleteSwCoreExperience(int id)
        {
            var SwCoreExperiences = dbContext.SwCoreExperiences.FirstOrDefault(x => x.CoreExperienceId == id);
            dbContext.Entry(SwCoreExperiences).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwCoreExperiences;
        }

        public IEnumerable<SwCoreExperience> GetSwCoreExperience()
        {
            var SwCoreExperiences = dbContext.SwCoreExperiences.ToList();
            return SwCoreExperiences;
        }

        public SwCoreExperience GetSwCoreExperienceById(int id)
        {
            var SwCoreExperiences = dbContext.SwCoreExperiences.FirstOrDefault(x => x.CoreExperienceId == id);
            return SwCoreExperiences;
        }

        public SwCoreExperience UpdateSwCoreExperience(SwCoreExperience SwCoreExperiences)
        {
            dbContext.Entry(SwCoreExperiences).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwCoreExperiences;
        }
    }
}
