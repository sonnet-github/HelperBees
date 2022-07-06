using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ScSupportCoordinatorProfileService : IScSupportCoordinatorProfileService
    {
        HelperBeesContext dbContext;
        public ScSupportCoordinatorProfileService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ScSupportCoordinatorProfile AddScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfile)
        {
            if (ScSupportCoordinatorProfile != null)
            {
                dbContext.ScSupportCoordinatorProfiles.Add(ScSupportCoordinatorProfile);
                dbContext.SaveChanges();
                return ScSupportCoordinatorProfile;
            }
            return null;
        }

        public ScSupportCoordinatorProfile DeleteScSupportCoordinatorProfile(int id)
        {
            var ScSupportCoordinatorProfiles = dbContext.ScSupportCoordinatorProfiles.FirstOrDefault(x => x.SupportCoordinatorProfileId == id);
            dbContext.Entry(ScSupportCoordinatorProfiles).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ScSupportCoordinatorProfiles;
        }

        public IEnumerable<ScSupportCoordinatorProfile> GetScSupportCoordinatorProfile()
        {
            var ScSupportCoordinatorProfiles = dbContext.ScSupportCoordinatorProfiles.ToList();
            return ScSupportCoordinatorProfiles;
        }

        public ScSupportCoordinatorProfile GetScSupportCoordinatorProfileById(int id)
        {
            var ScSupportCoordinatorProfiles = dbContext.ScSupportCoordinatorProfiles.FirstOrDefault(x => x.SupportCoordinatorProfileId == id);
            return ScSupportCoordinatorProfiles;
        }

        public ScSupportCoordinatorProfile GetScSupportCoordinatorProfileByCoordinatorId(int coordinatorid)
        {
            var ScSupportCoordinatorProfiles = dbContext.ScSupportCoordinatorProfiles.FirstOrDefault(x => x.SupportCoordinatorId == coordinatorid);
            return ScSupportCoordinatorProfiles;
        }

        public ScSupportCoordinatorProfile UpdateScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfiles)
        {
            dbContext.Entry(ScSupportCoordinatorProfiles).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ScSupportCoordinatorProfiles;
        }
    }
}
