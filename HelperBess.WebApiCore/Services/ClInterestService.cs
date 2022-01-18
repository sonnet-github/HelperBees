using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClInterestService : IClInterestService
    {
        HelperBeesContext dbContext;
        public ClInterestService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClInterest AddClInterest(ClInterest ClInterest)
        {
            if (ClInterest != null)
            {
                dbContext.ClInterests.Add(ClInterest);
                dbContext.SaveChanges();
                return ClInterest;
            }
            return null;
        }

        public ClInterest DeleteClInterest(int id)
        {
            var ClInterests = dbContext.ClInterests.FirstOrDefault(x => x.InterestsId == id);
            dbContext.Entry(ClInterests).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClInterests;
        }

        public IEnumerable<ClInterest> GetClInterest()
        {
            var ClInterests = dbContext.ClInterests.ToList();
            return ClInterests;
        }

        public ClInterest GetClInterestById(int id)
        {
            var ClInterests = dbContext.ClInterests.FirstOrDefault(x => x.InterestsId == id);
            return ClInterests;
        }

        public ClInterest UpdateClInterest(ClInterest ClInterests)
        {
            dbContext.Entry(ClInterests).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClInterests;
        }
    }
}
