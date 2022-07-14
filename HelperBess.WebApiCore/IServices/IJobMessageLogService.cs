using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IJobMessageLogService
    {
        IEnumerable<JobMessageLog> GetJobMessageLog();
        JobMessageLog GetJobMessageLogById(int id);
        IEnumerable<JobMessageLog> GetJobMessageLogByParticipantId(int participantid);
        IEnumerable<JobMessageLog> GetJobMessageLogByAssignmentIdAsc(int assignmentid);
        IEnumerable<JobMessageLog> GetJobMessageLogByAssignmentIdDesc(int assignmentid);
        IEnumerable<JobMessageLogGet> GetJobMessageLogByJobIdAsc(int assignmentid);
        IEnumerable<JobMessageLogGet> GetJobMessageLogByJobIdDesc(int assignmentid);
        JobMessageLog AddJobMessageLog(JobMessageLog JobMessageLog);
        JobMessageLog UpdateJobMessageLog(JobMessageLog JobMessageLog);
        JobMessageLog DeleteJobMessageLog(int id);
    }
}
