using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwEmailPreferenceService : ISwEmailPreferenceService
    {
        HelperBeesContext dbContext;
        public SwEmailPreferenceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwEmailPreference AddSwEmailPreference(SwEmailPreference SwEmailPreference)
        {
            if (SwEmailPreference != null)
            {
                dbContext.SwEmailPreferences.Add(SwEmailPreference);
                dbContext.SaveChanges();
                return SwEmailPreference;
            }
            return null;
        }

        public SwEmailPreference DeleteSwEmailPreference(int id)
        {
            var SwEmailPreferences = dbContext.SwEmailPreferences.FirstOrDefault(x => x.EmailPreferencesId == id);
            dbContext.Entry(SwEmailPreferences).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwEmailPreferences;
        }

        public IEnumerable<SwEmailPreference> GetSwEmailPreference()
        {
            var SwEmailPreferences = dbContext.SwEmailPreferences.ToList();
            return SwEmailPreferences;
        }

        public SwEmailPreference GetSwEmailPreferenceById(int id)
        {
            var SwEmailPreferences = dbContext.SwEmailPreferences.FirstOrDefault(x => x.EmailPreferencesId == id);
            return SwEmailPreferences;
        }

        public SwEmailPreference GetSwEmailPreferenceBySupportWorkerId(int supportWorkerId)
        {
            var SwEmailPreferences = dbContext.SwEmailPreferences.FirstOrDefault(x => x.SupportWorkerId == supportWorkerId);
            return SwEmailPreferences;
        }

        public SwEmailPreference UpdateSwEmailPreference(SwEmailPreference SwEmailPreferences)
        {
            dbContext.Entry(SwEmailPreferences).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwEmailPreferences;
        }
    }
}
