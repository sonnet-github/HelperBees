using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerProfileService : ISwSupportWorkerProfileService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerProfileService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerProfile AddSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfile)
        {
            if (SwSupportWorkerProfile != null)
            {
                dbContext.SwSupportWorkerProfiles.Add(SwSupportWorkerProfile);
                dbContext.SaveChanges();
                return SwSupportWorkerProfile;
            }
            return null;
        }

        public SwSupportWorkerProfile DeleteSwSupportWorkerProfile(int id)
        {
            var SwSupportWorkerProfiles = dbContext.SwSupportWorkerProfiles.FirstOrDefault(x => x.SupportWorkerProfileId == id);
            dbContext.Entry(SwSupportWorkerProfiles).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerProfiles;
        }

        public IEnumerable<SwSupportWorkerProfile> GetSwSupportWorkerProfile()
        {
            var SwSupportWorkerProfiles = dbContext.SwSupportWorkerProfiles.ToList();
            return SwSupportWorkerProfiles;
        }

        public IEnumerable<SwSupportWorkerProfile> GetSwSupportWorkerProfileByLocation(string location)
        {
            var supportWorkers = GetSwSupportWorkerProfile();
            List<SwSupportWorkerProfile> filteredSupportWorkers = new List<SwSupportWorkerProfile>();

            foreach (var supportWorker in supportWorkers)
            {
                var postAddr =
                    supportWorker.PostAddrUnitNumber + " " +
                    supportWorker.PostAddrStreet + " " +
                    supportWorker.PostAddrSuburb + " " +
                    supportWorker.PostAddrState + " " +
                    supportWorker.PostAddrCountry;

                var resAddr =
                    supportWorker.ResAddrUnitNumber + " " +
                    supportWorker.ResAddrStreet + " " +
                    supportWorker.ResAddrSuburb + " " +
                    supportWorker.ResAddrState + " " +
                    supportWorker.ResAddrCountry;

                if (postAddr.Contains(location) || resAddr.Contains(location))
                    filteredSupportWorkers.Add(supportWorker);
            }

            return filteredSupportWorkers;
        }

        public SwSupportWorkerProfile GetSwSupportWorkerProfileById(int id)
        {
            var SwSupportWorkerProfiles = dbContext.SwSupportWorkerProfiles.FirstOrDefault(x => x.SupportWorkerProfileId == id);
            return SwSupportWorkerProfiles;
        }

        public SwSupportWorkerProfile UpdateSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfiles)
        {
            dbContext.Entry(SwSupportWorkerProfiles).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerProfiles;
        }
    }
}
