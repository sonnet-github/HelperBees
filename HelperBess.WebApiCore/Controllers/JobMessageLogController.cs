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
    public class JobMessageLogController : ControllerBase
    {
        private readonly IJobMessageLogService JobMessageLogServiceService;
        public JobMessageLogController(IJobMessageLogService iJobMessageLogService)
        {
            JobMessageLogServiceService = iJobMessageLogService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLog")]
        public IEnumerable<JobMessageLog> GetJobMessageLog()
        {
            return JobMessageLogServiceService.GetJobMessageLog();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/JobMessageLog/AddJobMessageLog")]
        public JobMessageLog AddJobMessageLog(JobMessageLog JobMessageLog)
        {
            return JobMessageLogServiceService.AddJobMessageLog(JobMessageLog);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/JobMessageLog/UpdateJobMessageLog")]
        public JobMessageLog UpdateJobMessageLog(JobMessageLog JobMessageLog)
        {
            return JobMessageLogServiceService.UpdateJobMessageLog(JobMessageLog);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/JobMessageLog/DeleteJobMessageLog")]
        public JobMessageLog DeleteJobMessageLog(int id)
        {
            return JobMessageLogServiceService.DeleteJobMessageLog(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLogById")]
        public JobMessageLog GetJobMessageLogById(int id)
        {
            return JobMessageLogServiceService.GetJobMessageLogById(id);
        }
    }
}
