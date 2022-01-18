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
    public class JobTimeController : ControllerBase
    {
        private readonly IJobTimeService JobTimeServiceService;
        public JobTimeController(IJobTimeService iJobTimeService)
        {
            JobTimeServiceService = iJobTimeService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobTime/GetJobTime")]
        public IEnumerable<JobTime> GetJobTime()
        {
            return JobTimeServiceService.GetJobTime();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/JobTime/AddJobTime")]
        public JobTime AddJobTime(JobTime JobTime)
        {
            return JobTimeServiceService.AddJobTime(JobTime);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/JobTime/UpdateJobTime")]
        public JobTime UpdateJobTime(JobTime JobTime)
        {
            return JobTimeServiceService.UpdateJobTime(JobTime);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/JobTime/DeleteJobTime")]
        public JobTime DeleteJobTime(int id)
        {
            return JobTimeServiceService.DeleteJobTime(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobTime/GetJobTimeById")]
        public JobTime GetJobTimeById(int id)
        {
            return JobTimeServiceService.GetJobTimeById(id);
        }
    }
}
