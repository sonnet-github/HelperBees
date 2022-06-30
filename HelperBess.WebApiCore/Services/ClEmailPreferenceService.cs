using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClEmailPreferenceService : ICLEmailPreferenceService
    {
        HelperBeesContext dbContext;
        public ClEmailPreferenceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public CLEmailPreference AddCLEmailPreference(CLEmailPreference ClEmailPreference)
        {
            if (ClEmailPreference != null)
            {
                dbContext.CLEmailPreference.Add(ClEmailPreference);
                dbContext.SaveChanges();
                return ClEmailPreference;
            }
            return null;
        }

        public CLEmailPreference DeleteCLEmailPreference(int id)
        {
            var ClEmailPreferences = dbContext.CLEmailPreference.FirstOrDefault(x => x.CLEmailPreferencesId == id);
            dbContext.Entry(ClEmailPreferences).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClEmailPreferences;
        }

        public IEnumerable<CLEmailPreference> GetCLEmailPreference()
        {
            var ClEmailPreferences = dbContext.CLEmailPreference.ToList();
            return ClEmailPreferences;
        }

        public CLEmailPreference GetCLEmailPreferenceById(int id)
        {
            var ClEmailPreferences = dbContext.CLEmailPreference.FirstOrDefault(x => x.CLEmailPreferencesId == id);
            return ClEmailPreferences;
        }

        public IEnumerable<CLEmailPreference> GetCLEmailPreferenceByAccountHolderId(int accountholderid)
        {
            var ClEmailPreferences = dbContext.CLEmailPreference.Where(x => x.AccountHolderId == accountholderid);
            return ClEmailPreferences;
        }

        public CLEmailPreference UpdateCLEmailPreference(CLEmailPreference ClEmailPreferences)
        {
            dbContext.Entry(ClEmailPreferences).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClEmailPreferences;
        }
    }
}
