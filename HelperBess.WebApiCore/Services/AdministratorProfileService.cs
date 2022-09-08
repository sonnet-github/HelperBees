using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class AdministratorProfileService : IAdministratorProfileService
    {
        HelperBeesContext dbContext;
        public AdministratorProfileService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public AdministratorProfile AddAdministratorProfile(AdministratorProfile AdministratorProfile)
        {
            if (AdministratorProfile != null)
            {
                dbContext.AdministratorProfiles.Add(AdministratorProfile);
                dbContext.SaveChanges();
                return AdministratorProfile;
            }
            return null;
        }

        public AdministratorProfile DeleteAdministratorProfile(int id)
        {
            var AdministratorProfiles = dbContext.AdministratorProfiles.FirstOrDefault(x => x.AdministratorProfileId == id);
            dbContext.Entry(AdministratorProfiles).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return AdministratorProfiles;
        }

        public IEnumerable<AdministratorProfile> GetAdministratorProfile()
        {
            var AdministratorProfiles = dbContext.AdministratorProfiles.ToList();
            return AdministratorProfiles;
        }

        public AdministratorProfile GetAdministratorProfileById(int id)
        {
            var AdministratorProfiles = dbContext.AdministratorProfiles.FirstOrDefault(x => x.AdministratorProfileId == id);
            return AdministratorProfiles;
        }

        public AdministratorProfile GetAdministratorProfileByAdminId(int adminid)
        {
            var AdministratorProfiles = dbContext.AdministratorProfiles.FirstOrDefault(x => x.AdministratorId == adminid);
            return AdministratorProfiles;
        }

        public AdministratorProfile UpdateAdministratorProfile(AdministratorProfile AdministratorProfiles)
        {
            dbContext.Entry(AdministratorProfiles).State = EntityState.Modified;
            dbContext.SaveChanges();
            return AdministratorProfiles;
        }
    }
}
