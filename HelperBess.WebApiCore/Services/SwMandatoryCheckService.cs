using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwMandatoryCheckService : ISwMandatoryCheckService
    {
        HelperBeesContext dbContext;
        public SwMandatoryCheckService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwMandatoryCheck AddSwMandatoryCheck(SwMandatoryCheck SwMandatoryCheck)
        {
            if (SwMandatoryCheck != null)
            {
                dbContext.SwMandatoryChecks.Add(SwMandatoryCheck);
                dbContext.SaveChanges();
                return SwMandatoryCheck;
            }
            return null;
        }

        public SwMandatoryCheck DeleteSwMandatoryCheck(int id)
        {
            var SwMandatoryChecks = dbContext.SwMandatoryChecks.FirstOrDefault(x => x.MandatoryCheckId == id);
            dbContext.Entry(SwMandatoryChecks).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwMandatoryChecks;
        }

        public IEnumerable<SwMandatoryCheck> GetSwMandatoryCheck()
        {
            var SwMandatoryChecks = dbContext.SwMandatoryChecks.ToList();
            return SwMandatoryChecks;
        }

        public SwMandatoryCheck GetSwMandatoryCheckById(int id)
        {
            var SwMandatoryChecks = dbContext.SwMandatoryChecks.FirstOrDefault(x => x.MandatoryCheckId == id);
            return SwMandatoryChecks;
        }

        public SwMandatoryCheck UpdateSwMandatoryCheck(SwMandatoryCheck SwMandatoryChecks)
        {
            dbContext.Entry(SwMandatoryChecks).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwMandatoryChecks;
        }
    }
}
