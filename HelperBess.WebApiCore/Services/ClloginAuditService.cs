using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClloginAuditService : IClloginAuditService
    {
        HelperBeesContext dbContext;
        public ClloginAuditService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClloginAudit AddClloginAudit(ClloginAudit ClloginAudit)
        {
            if (ClloginAudit != null)
            {
                dbContext.ClloginAudits.Add(ClloginAudit);
                dbContext.SaveChanges();
                return ClloginAudit;
            }
            return null;
        }

        public ClloginAudit DeleteClloginAudit(int id)
        {
            var ClloginAudits = dbContext.ClloginAudits.FirstOrDefault(x => x.ClloginAuditId == id);
            dbContext.Entry(ClloginAudits).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClloginAudits;
        }

        public IEnumerable<ClloginAudit> GetClloginAudit()
        {
            var ClloginAudits = dbContext.ClloginAudits.ToList();
            return ClloginAudits;
        }

        public ClloginAudit GetClloginAuditById(int id)
        {
            var ClloginAudits = dbContext.ClloginAudits.FirstOrDefault(x => x.ClloginAuditId == id);
            return ClloginAudits;
        }

        public ClloginAudit UpdateClloginAudit(ClloginAudit ClloginAudits)
        {
            dbContext.Entry(ClloginAudits).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClloginAudits;
        }
    }
}
