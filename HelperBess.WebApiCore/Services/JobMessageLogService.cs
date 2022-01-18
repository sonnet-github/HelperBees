using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class JobMessageLogService : IJobMessageLogService
    {
        HelperBeesContext dbContext;
        public JobMessageLogService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public JobMessageLog AddJobMessageLog(JobMessageLog JobMessageLog)
        {
            if (JobMessageLog != null)
            {
                dbContext.JobMessageLogs.Add(JobMessageLog);
                dbContext.SaveChanges();
                return JobMessageLog;
            }
            return null;
        }

        public JobMessageLog DeleteJobMessageLog(int id)
        {
            var JobMessageLogs = dbContext.JobMessageLogs.FirstOrDefault(x => x.JobMessageLogId == id);
            dbContext.Entry(JobMessageLogs).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return JobMessageLogs;
        }

        public IEnumerable<JobMessageLog> GetJobMessageLog()
        {
            var JobMessageLogs = dbContext.JobMessageLogs.ToList();
            return JobMessageLogs;
        }

        public JobMessageLog GetJobMessageLogById(int id)
        {
            var JobMessageLogs = dbContext.JobMessageLogs.FirstOrDefault(x => x.JobMessageLogId == id);
            return JobMessageLogs;
        }

        public JobMessageLog UpdateJobMessageLog(JobMessageLog JobMessageLogs)
        {
            dbContext.Entry(JobMessageLogs).State = EntityState.Modified;
            dbContext.SaveChanges();
            return JobMessageLogs;
        }
    }
}
