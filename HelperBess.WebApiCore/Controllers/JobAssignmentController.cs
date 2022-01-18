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
    public class JobAssignmentController : ControllerBase
    {

        private readonly IJobAssignmentService JobAssignmentServiceService;
        public JobAssignmentController(IJobAssignmentService iJobAssignmentService)
        {
            JobAssignmentServiceService = iJobAssignmentService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobAssignment/GetJobAssignment")]
        public IEnumerable<JobAssignment> GetJobAssignment()
        {
            return JobAssignmentServiceService.GetJobAssignment();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/JobAssignment/AddJobAssignment")]
        public JobAssignment AddJobAssignment(JobAssignment JobAssignment)
        {
            return JobAssignmentServiceService.AddJobAssignment(JobAssignment);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/JobAssignment/UpdateJobAssignment")]
        public JobAssignment UpdateJobAssignment(JobAssignment JobAssignment)
        {
            return JobAssignmentServiceService.UpdateJobAssignment(JobAssignment);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/JobAssignment/DeleteJobAssignment")]
        public JobAssignment DeleteJobAssignment(int id)
        {
            return JobAssignmentServiceService.DeleteJobAssignment(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobAssignment/GetJobAssignmentById")]
        public JobAssignment GetJobAssignmentById(int id)
        {
            return JobAssignmentServiceService.GetJobAssignmentById(id);
        }
    }
}
