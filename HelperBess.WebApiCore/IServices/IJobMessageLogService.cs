using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IJobMessageLogService
    {
        IEnumerable<JobMessageLog> GetJobMessageLog();
        JobMessageLog GetJobMessageLogById(int id);
        JobMessageLog AddJobMessageLog(JobMessageLog JobMessageLog);
        JobMessageLog UpdateJobMessageLog(JobMessageLog JobMessageLog);
        JobMessageLog DeleteJobMessageLog(int id);
    }
}
