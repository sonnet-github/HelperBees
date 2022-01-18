using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HelperBess.WebApiCore.Contants;

namespace HelperBess.WebApiCore.Services
{
    public class JobService : IJobService
    {
        HelperBeesContext dbContext;
        public JobService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public Job AddJob(Job Job)
        {
            if (Job != null)
            {
                dbContext.Jobs.Add(Job);
                dbContext.SaveChanges();
                return Job;
            }
            return null;
        }

        public Job DeleteJob(int id)
        {
            var Jobs = dbContext.Jobs.FirstOrDefault(x => x.JobId == id);
            dbContext.Entry(Jobs).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return Jobs;
        }

        public IEnumerable<Job> GetJob()
        {
            var Jobs = dbContext.Jobs.ToList();
            return Jobs;
        }

        public IEnumerable<Job> GetJobByParticipantId(int participantId, bool includeArchived)
        {
            IEnumerable<Job> Jobs;

            if(includeArchived)
                Jobs  = dbContext.Jobs.Where(x => x.ParticipantId == participantId);
            else
                Jobs = dbContext.Jobs.Where(x => x.ParticipantId == participantId && x.JobStatus != JobStatus.Archived);

            return Jobs;
        }

        public Job GetJobById(int id)
        {
            var Jobs = dbContext.Jobs.FirstOrDefault(x => x.JobId == id);
            return Jobs;
        }

        public Job UpdateJob(Job Jobs)
        {
            dbContext.Entry(Jobs).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Jobs;
        }

        public IEnumerable<Job> SearchJob(string suburb, string services, string gender, string hours)
        {
            var Jobs = dbContext.Jobs.ToList();
            IEnumerable<Job> filteredJobs;

            filteredJobs = Jobs.Where(x =>
                (string.IsNullOrEmpty(suburb) || x.Suburb.Contains(suburb)) &&
                (string.IsNullOrEmpty(services) || x.SupportWorkDescription.Contains(services)) &&
                (string.IsNullOrEmpty(gender) || x.GenderPreference.Contains(gender)) &&
                (string.IsNullOrEmpty(hours) || x.Hours.Contains(hours)));

            return filteredJobs;
        }
    }
}
