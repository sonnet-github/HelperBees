using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class JobTimeService : IJobTimeService
    {
        HelperBeesContext dbContext;
        public JobTimeService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public JobTime AddJobTime(JobTime JobTime)
        {
            if (JobTime != null)
            {
                dbContext.JobTimes.Add(JobTime);
                dbContext.SaveChanges();
                return JobTime;
            }
            return null;
        }

        public JobTime DeleteJobTime(int id)
        {
            var JobTimes = dbContext.JobTimes.FirstOrDefault(x => x.JobTimesId == id);
            dbContext.Entry(JobTimes).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return JobTimes;
        }

        public IEnumerable<JobTime> GetJobTime()
        {
            var JobTimes = dbContext.JobTimes.ToList();
            return JobTimes;
        }

        public JobTime GetJobTimeById(int id)
        {
            var JobTimes = dbContext.JobTimes.FirstOrDefault(x => x.JobTimesId == id);
            return JobTimes;
        }

        public JobTime UpdateJobTime(JobTime JobTimes)
        {
            dbContext.Entry(JobTimes).State = EntityState.Modified;
            dbContext.SaveChanges();
            return JobTimes;
        }
    }
}
