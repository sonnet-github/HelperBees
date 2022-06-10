using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class JobAssignmentService :IJobAssignmentService
    {
        HelperBeesContext dbContext;
        public JobAssignmentService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public JobAssignment AddJobAssignment(JobAssignment JobAssignment)
        {
            if (JobAssignment != null)
            {
                dbContext.JobAssignments.Add(JobAssignment);
                dbContext.SaveChanges();
                return JobAssignment;
            }
            return null;
        }

        public JobAssignment DeleteJobAssignment(int id)
        {
            var JobAssignments = dbContext.JobAssignments.FirstOrDefault(x => x.JobAssignmentId == id);
            dbContext.Entry(JobAssignments).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return JobAssignments;
        }

        public IEnumerable<JobAssignment> GetJobAssignment()
        {
            var JobAssignments = dbContext.JobAssignments.ToList();
            return JobAssignments;
        }

        public JobAssignment GetJobAssignmentById(int id)
        {
            var JobAssignments = dbContext.JobAssignments.FirstOrDefault(x => x.JobAssignmentId == id);
            return JobAssignments;
        }

        public JobAssignment UpdateJobAssignment(JobAssignment JobAssignments)
        {
            dbContext.Entry(JobAssignments).State = EntityState.Modified;
            dbContext.SaveChanges();
            return JobAssignments;
        }

        public IEnumerable<JobAssignment> GetJobAssignmentByParticipantId(int participantId)
        {
            var JobAssignments = dbContext.JobAssignments.Where(x => x.Job.ParticipantId == participantId);
            return JobAssignments;
        }
    }
}
