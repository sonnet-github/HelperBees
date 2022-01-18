using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ScloginAuditService : IScloginAuditService
    {
        HelperBeesContext dbContext;
        public ScloginAuditService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ScloginAudit AddScloginAudit(ScloginAudit ScloginAudit)
        {
            if (ScloginAudit != null)
            {
                dbContext.ScloginAudits.Add(ScloginAudit);
                dbContext.SaveChanges();
                return ScloginAudit;
            }
            return null;
        }

        public ScloginAudit DeleteScloginAudit(int id)
        {
            var ScloginAudits = dbContext.ScloginAudits.FirstOrDefault(x => x.ScloginAuditId == id);
            dbContext.Entry(ScloginAudits).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ScloginAudits;
        }

        public IEnumerable<ScloginAudit> GetScloginAudit()
        {
            var ScloginAudits = dbContext.ScloginAudits.ToList();
            return ScloginAudits;
        }

        public ScloginAudit GetScloginAuditById(int id)
        {
            var ScloginAudits = dbContext.ScloginAudits.FirstOrDefault(x => x.ScloginAuditId == id);
            return ScloginAudits;
        }

        public ScloginAudit UpdateScloginAudit(ScloginAudit ScloginAudits)
        {
            dbContext.Entry(ScloginAudits).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ScloginAudits;
        }
    }
}
