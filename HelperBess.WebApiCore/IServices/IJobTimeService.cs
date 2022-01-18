using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IJobTimeService
    {
        IEnumerable<JobTime> GetJobTime();
        JobTime GetJobTimeById(int id);
        JobTime AddJobTime(JobTime JobTime);
        JobTime UpdateJobTime(JobTime JobTime);
        JobTime DeleteJobTime(int id);
    }
}
