using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwloginAuditService : ISwloginAuditService
    {
        HelperBeesContext dbContext;
        public SwloginAuditService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwloginAudit AddSwloginAudit(SwloginAudit SwloginAudit)
        {
            if (SwloginAudit != null)
            {
                dbContext.SwloginAudits.Add(SwloginAudit);
                dbContext.SaveChanges();
                return SwloginAudit;
            }
            return null;
        }

        public SwloginAudit DeleteSwloginAudit(int id)
        {
            var SwloginAudits = dbContext.SwloginAudits.FirstOrDefault(x => x.SwloginAuditId == id);
            dbContext.Entry(SwloginAudits).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwloginAudits;
        }

        public IEnumerable<SwloginAudit> GetSwloginAudit()
        {
            var SwloginAudits = dbContext.SwloginAudits.ToList();
            return SwloginAudits;
        }

        public SwloginAudit GetSwloginAuditById(int id)
        {
            var SwloginAudits = dbContext.SwloginAudits.FirstOrDefault(x => x.SwloginAuditId == id);
            return SwloginAudits;
        }

        public SwloginAudit UpdateSwloginAudit(SwloginAudit SwloginAudits)
        {
            dbContext.Entry(SwloginAudits).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwloginAudits;
        }
    }
}
