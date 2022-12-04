using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerCoreExperienceService : ISwSupportWorkerCoreExperienceService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerCoreExperienceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerCoreExperience AddSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience)
        {
            if (SwSupportWorkerCoreExperience != null)
            {
                dbContext.SwSupportWorkerCoreExperiences.Add(SwSupportWorkerCoreExperience);
                dbContext.SaveChanges();
                return SwSupportWorkerCoreExperience;
            }
            return null;
        }

        public SwSupportWorkerCoreExperience DeleteSwSupportWorkerCoreExperience(int id)
        {
            var SwSupportWorkerCoreExperiences = dbContext.SwSupportWorkerCoreExperiences.FirstOrDefault(x => x.SupportWorkerCoreExperienceId == id);
            dbContext.Entry(SwSupportWorkerCoreExperiences).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerCoreExperiences;
        }

        public IEnumerable<SwSupportWorkerCoreExperience> DeleteSwSupportWorkerCoreExperiencebySupportWorkerID(int SupportWorkerId)
        {
            var SwSupportWorkerCoreExperiences = dbContext.SwSupportWorkerCoreExperiences.Where(x => x.SupportWorkerId == SupportWorkerId).ToList();
            if (SwSupportWorkerCoreExperiences.Count > 0)
            {
                foreach (var n in SwSupportWorkerCoreExperiences)
                {
                    var SwSupportWorkerCoreExperiencesx = dbContext.SwSupportWorkerCoreExperiences.FirstOrDefault(x => x.SupportWorkerId == n.SupportWorkerId);
                    dbContext.Entry(SwSupportWorkerCoreExperiencesx).State = EntityState.Deleted;
                    dbContext.SaveChanges();

                }
            }
            return SwSupportWorkerCoreExperiences;
        }



        public IEnumerable<SwSupportWorkerCoreExperience> GetSwSupportWorkerCoreExperience()
        {
            var SwSupportWorkerCoreExperiences = dbContext.SwSupportWorkerCoreExperiences.ToList();
            return SwSupportWorkerCoreExperiences;
        }

        public SwSupportWorkerCoreExperience GetSwSupportWorkerCoreExperienceById(int id)
        {
            var SwSupportWorkerCoreExperiences = dbContext.SwSupportWorkerCoreExperiences.FirstOrDefault(x => x.SupportWorkerCoreExperienceId == id);
            return SwSupportWorkerCoreExperiences;
        }

        public SwSupportWorkerCoreExperience UpdateSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperiences)
        {
            dbContext.Entry(SwSupportWorkerCoreExperiences).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerCoreExperiences;
        }

        public IEnumerable<SwSupportWorkerCoreExperience> GetSwSupportWorkerCoreExperienceBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerCoreExperiences = dbContext.SwSupportWorkerCoreExperiences.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerCoreExperiences;
        }
    }
}
