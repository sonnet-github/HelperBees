using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClAccountHolderProfileService : IClAccountHolderProfileService
    {
        HelperBeesContext dbContext;
        public ClAccountHolderProfileService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClAccountHolderProfile AddClAccountHolderProfile(ClAccountHolderProfile ClAccountHolderProfile)
        {
            if (ClAccountHolderProfile != null)
            {
                dbContext.ClAccountHolderProfiles.Add(ClAccountHolderProfile);
                dbContext.SaveChanges();
                return ClAccountHolderProfile;
            }
            return null;
        }

        public ClAccountHolderProfile DeleteClAccountHolderProfile(int id)
        {
            var clAccountHolderProfile = dbContext.ClAccountHolderProfiles.FirstOrDefault(x => x.AccountHolderProfileId == id);
            dbContext.Entry(clAccountHolderProfile).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return clAccountHolderProfile;
        }

        public IEnumerable<ClAccountHolderProfile> GetClAccountHolderProfile()
        {
            var clAccountHolderProfile = dbContext.ClAccountHolderProfiles.ToList();
            return clAccountHolderProfile;
        }

        public ClAccountHolderProfile GetClAccountHolderProfileById(int id)
        {
            var clAccountHolderProfile = dbContext.ClAccountHolderProfiles.FirstOrDefault(x => x.AccountHolderProfileId == id);
            return clAccountHolderProfile;
        }

        public ClAccountHolderProfile GetClAccountHolderProfileByAccountHolder(int accountHolderId)
        {
            var clAccountHolderProfile = dbContext.ClAccountHolderProfiles.FirstOrDefault(x => x.AccountHolderId == accountHolderId);
            return clAccountHolderProfile;
        }

        public ClAccountHolderProfile UpdateClAccountHolderProfile(ClAccountHolderProfile clAccountHolderProfile)
        {
            dbContext.Entry(clAccountHolderProfile).State = EntityState.Modified;
            dbContext.SaveChanges();
            return clAccountHolderProfile;
        }
    }
}
