using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public IActionResult GetJobMessageLog()
        {
            try
            {
                List<JobMessageLog> logs = JobMessageLogServiceService.GetJobMessageLog().ToList();

                if (logs != null && logs.Any())
                {
                    return Ok(logs);
                }
                else
                {
                    return BadRequest("No job message log(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/JobMessageLog/AddJobMessageLog")]
        public IActionResult AddJobMessageLog(JobMessageLog JobMessageLog)
        {
            try
            {
                JobMessageLog newLog = JobMessageLogServiceService.AddJobMessageLog(JobMessageLog);

                if (newLog != null)
                {
                    return Ok(newLog);
                }
                else
                {
                    return BadRequest("Failed to add job message log.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/JobMessageLog/UpdateJobMessageLog")]
        public IActionResult UpdateJobMessageLog(JobMessageLog JobMessageLog)
        {
            try
            {
                JobMessageLog currentlog = JobMessageLogServiceService.GetJobMessageLogById(JobMessageLog.JobMessageLogId);

                if (currentlog != null)
                {
                    currentlog.JobMessageLogId = JobMessageLog.JobMessageLogId;
                    currentlog.JobAssignmentId = JobMessageLog.JobAssignmentId;
                    currentlog.MessageType = JobMessageLog.MessageType;
                    currentlog.MessageDateTime = JobMessageLog.MessageDateTime;
                    currentlog.Message = JobMessageLog.Message;

                    JobMessageLog updatedlog = JobMessageLogServiceService.UpdateJobMessageLog(currentlog);

                    if (updatedlog != null)
                    {
                        return Ok(updatedlog);
                    }
                    else
                    {
                        return BadRequest("Failed to update job message log.");
                    }
                }
                else
                {
                    return BadRequest("Job message log not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/JobMessageLog/DeleteJobMessageLog")]
        public IActionResult DeleteJobMessageLog(int id)
        {
            try
            {
                JobMessageLog currentLog = JobMessageLogServiceService.GetJobMessageLogById(id);

                if (currentLog != null)
                {
                    JobMessageLog log = JobMessageLogServiceService.DeleteJobMessageLog(id);

                    return Ok(log);
                }
                else
                {
                    return BadRequest("Job message log not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLogById")]
        public IActionResult GetJobMessageLogById(int id)
        {
            try
            {
                JobMessageLog log = JobMessageLogServiceService.GetJobMessageLogById(id);

                if (log != null)
                {
                    return Ok(log);
                }
                else
                {
                    return BadRequest("Job message log not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
