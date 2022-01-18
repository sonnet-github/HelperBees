using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwServiceService : ISwServiceService
    {
        HelperBeesContext dbContext;
        public SwServiceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwService AddSwService(SwService SwService)
        {
            if (SwService != null)
            {
                dbContext.SwServices.Add(SwService);
                dbContext.SaveChanges();
                return SwService;
            }
            return null;
        }

        public SwService DeleteSwService(int id)
        {
            var SwServices = dbContext.SwServices.FirstOrDefault(x => x.ServiceId == id);
            dbContext.Entry(SwServices).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwServices;
        }

        public IEnumerable<SwService> GetSwService()
        {
            var SwServices = dbContext.SwServices.ToList();
            return SwServices;
        }

        public SwService GetSwServiceById(int id)
        {
            var SwServices = dbContext.SwServices.FirstOrDefault(x => x.ServiceId == id);
            return SwServices;
        }

        public SwService UpdateSwService(SwService SwServices)
        {
            dbContext.Entry(SwServices).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwServices;
        }
    }
}
