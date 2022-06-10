using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IJobAssignmentService
    {
        IEnumerable<JobAssignment> GetJobAssignment();
        JobAssignment GetJobAssignmentById(int id);

        IEnumerable<JobAssignment> GetJobAssignmentByParticipantId(int participantId);

        JobAssignment AddJobAssignment(JobAssignment JobAssignment);
        JobAssignment UpdateJobAssignment(JobAssignment JobAssignment);
        JobAssignment DeleteJobAssignment(int id);
    }
}
