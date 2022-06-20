using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwAvailabilityService : ISwAvailabilityService
    {
        HelperBeesContext dbContext;
        public SwAvailabilityService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwAvailability AddSwAvailability(SwAvailability SwAvailability)
        {
            if (SwAvailability != null)
            {
                dbContext.SwAvailabilities.Add(SwAvailability);
                dbContext.SaveChanges();
                return SwAvailability;
            }
            return null;
        }

        public SwAvailability DeleteSwAvailability(int id)
        {
            var SwAvailabilitys = dbContext.SwAvailabilities.FirstOrDefault(x => x.AvailabilityId == id);
            dbContext.Entry(SwAvailabilitys).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwAvailabilitys;
        }

        public IEnumerable<SwAvailability> GetSwAvailability()
        {
            var SwAvailabilitys = dbContext.SwAvailabilities.ToList();
            return SwAvailabilitys;
        }

        public SwAvailability GetSwAvailabilityById(int id)
        {
            var SwAvailabilitys = dbContext.SwAvailabilities.FirstOrDefault(x => x.AvailabilityId == id);
            return SwAvailabilitys;
        }

        public IEnumerable<SwAvailability> GetSwAvailabilityBySWId(int swid)
        {
            var SwAvailabilitys = dbContext.SwAvailabilities.Where(x => x.SupportWorkerId == swid);
            return SwAvailabilitys;
        }

        public SwAvailability UpdateSwAvailability(SwAvailability SwAvailabilitys)
        {
            dbContext.Entry(SwAvailabilitys).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwAvailabilitys;
        }
    }
}
