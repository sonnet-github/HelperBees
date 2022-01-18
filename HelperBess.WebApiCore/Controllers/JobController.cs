using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class JobController : ControllerBase
    {
        private readonly IJobService JobServiceService;
        public JobController(IJobService iJobService)
        {
            JobServiceService = iJobService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Job/GetJob")]
        public IEnumerable<Job> GetJob()
        {
            return JobServiceService.GetJob();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Job/SearchJob")]
        public IEnumerable<Job> SearchJob(string suburb = null, string services = null, string gender = null, string hours = null)
        {
            return JobServiceService.SearchJob(suburb, services, gender, hours);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Job/GetJobByParticipantId")]
        public IEnumerable<Job> GetJobByParticipantId(int participantId, bool includeArchived = false)
        {
            return JobServiceService.GetJobByParticipantId(participantId, includeArchived);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Job/AddJob")]
        public Job AddJob(Job Job)
        {
            return JobServiceService.AddJob(Job);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Job/UpdateJob")]
        public Job UpdateJob(Job Job)
        {
            return JobServiceService.UpdateJob(Job);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Job/DeleteJob")]
        public Job DeleteJob(int id)
        {
            return JobServiceService.DeleteJob(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Job/GetJobById")]
        public Job GetJobById(int id)
        {
            return JobServiceService.GetJobById(id);
        }
    }
}
