using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClJobServiceService : IClJobServiceService
    {
        HelperBeesContext dbContext;
        public ClJobServiceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClJobService AddClJobService(ClJobService ClJobService)
        {
            if (ClJobService != null)
            {
                dbContext.ClJobServices.Add(ClJobService);
                dbContext.SaveChanges();
                return ClJobService;
            }
            return null;
        }

        public ClJobService DeleteClJobService(int id)
        {
            var ClJobServices = dbContext.ClJobServices.FirstOrDefault(x => x.JobServiceId == id);
            dbContext.Entry(ClJobServices).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClJobServices;
        }

        public IEnumerable<ClJobService> GetClJobService()
        {
            var ClJobServices = dbContext.ClJobServices.ToList();
            return ClJobServices;
        }

        public ClJobService GetClJobServiceById(int id)
        {
            var ClJobServices = dbContext.ClJobServices.FirstOrDefault(x => x.JobServiceId == id);
            return ClJobServices;
        }

        public ClJobService UpdateClJobService(ClJobService ClJobServices)
        {
            dbContext.Entry(ClJobServices).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClJobServices;
        }
    }
}
