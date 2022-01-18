using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ScimpersonisationLoginAuditService : IScimpersonisationLoginAuditService
    {
        HelperBeesContext dbContext;
        public ScimpersonisationLoginAuditService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ScimpersonisationLoginAudit AddScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudit)
        {
            if (ScimpersonisationLoginAudit != null)
            {
                dbContext.ScimpersonisationLoginAudits.Add(ScimpersonisationLoginAudit);
                dbContext.SaveChanges();
                return ScimpersonisationLoginAudit;
            }
            return null;
        }

        public ScimpersonisationLoginAudit DeleteScimpersonisationLoginAudit(int id)
        {
            var ScimpersonisationLoginAudits = dbContext.ScimpersonisationLoginAudits.FirstOrDefault(x => x.ScimpLoginAuditId == id);
            dbContext.Entry(ScimpersonisationLoginAudits).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ScimpersonisationLoginAudits;
        }

        public IEnumerable<ScimpersonisationLoginAudit> GetScimpersonisationLoginAudit()
        {
            var ScimpersonisationLoginAudits = dbContext.ScimpersonisationLoginAudits.ToList();
            return ScimpersonisationLoginAudits;
        }

        public ScimpersonisationLoginAudit GetScimpersonisationLoginAuditById(int id)
        {
            var ScimpersonisationLoginAudits = dbContext.ScimpersonisationLoginAudits.FirstOrDefault(x => x.ScimpLoginAuditId == id);
            return ScimpersonisationLoginAudits;
        }

        public ScimpersonisationLoginAudit UpdateScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudits)
        {
            dbContext.Entry(ScimpersonisationLoginAudits).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ScimpersonisationLoginAudits;
        }
    }
}
