using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IJobService
    {
        IEnumerable<Job> GetJobByParticipantId(int participantId, bool includeArchived);
        IEnumerable<Job> GetJob();
        IEnumerable<Job> SearchJob(string suburb, string services, string gender, string hours);
        Job GetJobById(int id);
        Job AddJob(Job Job);
        Job UpdateJob(Job Job);
        Job DeleteJob(int id);
    }
}
