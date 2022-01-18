using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ChangeLogService : IChangeLogService
    {
        HelperBeesContext dbContext;
        public ChangeLogService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ChangeLog AddChangeLog(ChangeLog ChangeLog)
        {
            if (ChangeLog != null)
            {
                dbContext.ChangeLogs.Add(ChangeLog);
                dbContext.SaveChanges();
                return ChangeLog;
            }
            return null;
        }

        public ChangeLog DeleteChangeLog(int id)
        {
            var changeLogs = dbContext.ChangeLogs.FirstOrDefault(x => x.ChangeLogId == id);
            dbContext.Entry(changeLogs).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return changeLogs;
        }

        public IEnumerable<ChangeLog> GetChangeLog()
        {
            var changeLogs = dbContext.ChangeLogs.ToList();
            return changeLogs;
        }

        public ChangeLog GetChangeLogById(int id)
        {
            var changeLogs = dbContext.ChangeLogs.FirstOrDefault(x => x.ChangeLogId == id);
            return changeLogs;
        }

        public ChangeLog UpdateChangeLog(ChangeLog changeLogs)
        {
            dbContext.Entry(changeLogs).State = EntityState.Modified;
            dbContext.SaveChanges();
            return changeLogs;
        }
    }
}
