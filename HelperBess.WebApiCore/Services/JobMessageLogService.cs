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

        public IEnumerable<JobMessageLog> GetJobMessageLogByParticipantId(int participantid)
        {
            var JobMessageLogs = dbContext.JobMessageLogs.Where(x => x.JobAssignment.Job.ParticipantId == participantid);
            return JobMessageLogs;
        }

        public IEnumerable<JobMessageLog> GetJobMessageLogByAssignmentIdAsc(int assignmentid)
        {
            var JobMessageLogs = dbContext.JobMessageLogs.Where(x => x.JobAssignmentId == assignmentid);
            return JobMessageLogs;
        }

        public IEnumerable<JobMessageLog> GetJobMessageLogByAssignmentIdDesc(int assignmentid)
        {
            var JobMessageLogs = dbContext.JobMessageLogs.Where(x => x.JobAssignmentId == assignmentid);
            return JobMessageLogs;
        }

       

        public IEnumerable<JobMessageLogGet> GetJobMessageLogByJobIdAsc(int jobid)
        {
            List <JobMessageLogGet> jobMessageLogGet= new List<JobMessageLogGet>();
            jobMessageLogGet = dbContext.JobMessageLogs.Where(x => x.JobAssignment.JobId == jobid).Select(a => new JobMessageLogGet { 
                JobMessageLogId = a.JobAssignmentId,
                JobAssignmentId = a.JobAssignmentId,
                MessageType = a.MessageType,
                MessageDateTime = a.MessageDateTime,
                Message = a.Message              

            }).ToList();
            //var JobMessageLogs = dbContext.JobMessageLogs.Where(x => x.JobAssignment.JobId == jobid);
            return jobMessageLogGet;
        }


        public IEnumerable<JobMessageLogGet> GetJobMessageLogByJobIdDesc(int jobid)
        {
            List<JobMessageLogGet> jobMessageLogGet = new List<JobMessageLogGet>();
            jobMessageLogGet = dbContext.JobMessageLogs.Where(x => x.JobAssignment.JobId == jobid).Select(a => new JobMessageLogGet
            {
                JobMessageLogId = a.JobAssignmentId,
                JobAssignmentId = a.JobAssignmentId,
                MessageType = a.MessageType,
                MessageDateTime = a.MessageDateTime,
                Message = a.Message

            }).ToList();
            //var JobMessageLogs = dbContext.JobMessageLogs.Where(x => x.JobAssignment.JobId == jobid);
            return jobMessageLogGet;
        }

        public JobMessageLog UpdateJobMessageLog(JobMessageLog JobMessageLogs)
        {
            dbContext.Entry(JobMessageLogs).State = EntityState.Modified;
            dbContext.SaveChanges();
            return JobMessageLogs;
        }
    }
}
