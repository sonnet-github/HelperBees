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
        private readonly IJobAssignmentService JobAssignmentServiceService;
        private readonly IJobService JobServiceService;
        public JobMessageLogController(IJobMessageLogService iJobMessageLogService, IJobAssignmentService iJobAssignmentService, IJobService iJobService)
        {
            JobMessageLogServiceService = iJobMessageLogService;
            JobAssignmentServiceService = iJobAssignmentService;
            JobServiceService = iJobService;
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

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLogByParticipantId")]
        public IActionResult GetJobMessageLogByParticipantId(int participantid)
        {
            try
            {
                List<JobMessageLog> logs = JobMessageLogServiceService.GetJobMessageLogByParticipantId(participantid).ToList();

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

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLogByAssignmentIdAsc")]
        public IActionResult GetJobMessageLogByAssignmentIdAsc(int assignmentid)
        {
            try
            {
                List<JobMessageLog> logs = JobMessageLogServiceService.GetJobMessageLogByAssignmentIdAsc(assignmentid).OrderBy(x => x.MessageDateTime).ToList();

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

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLogByAssignmentIdDesc")]
        public IActionResult GetJobMessageLogByAssignmentIdDesc(int assignmentid)
        {
            try
            {
                List<JobMessageLog> logs = JobMessageLogServiceService.GetJobMessageLogByAssignmentIdDesc(assignmentid).OrderByDescending(x => x.MessageDateTime).ToList();

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

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLogByJobIdAsc")]
        public IActionResult GetJobMessageLogByJobIdAsc(int jobid)
        {
            try
            {
              
                List<JobMessageLogGet> logs = JobMessageLogServiceService.GetJobMessageLogByJobIdAsc(jobid).OrderBy(x => x.MessageDateTime)
                    .Select(a => new JobMessageLogGet
                    {
                        JobMessageLogId = a.JobAssignmentId,
                        JobAssignmentId = a.JobAssignmentId,
                        MessageType = a.MessageType,
                        MessageDateTime = a.MessageDateTime,
                        Message = a.Message,
                        JobAssignmentGet = new JobAssignmentGet
                        {
                            JobAssignmentId = JobAssignmentServiceService.GetJobAssignmentById(a.JobAssignmentId).JobAssignmentId,
                            ParticipantID = JobServiceService.GetJobById(jobid).ParticipantId,
                            JobId = JobAssignmentServiceService.GetJobAssignmentById(a.JobAssignmentId).JobId,
                            SupportWorkerId = JobAssignmentServiceService.GetJobAssignmentById(a.JobAssignmentId).SupportWorkerId
                        }



                    })

                    .ToList();


                //  List<JobMessageLog> logs = JobMessageLogServiceService.GetJobMessageLogByJobIdDesc(jobid).OrderBy(x => x.MessageDateTime).ToList();

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

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobMessageLog/GetJobMessageLogByJobIdDesc")]
        public IActionResult GetJobMessageLogByJobIdDesc(int jobid)
        {
            try
            {
                List<JobMessageLogGet> logs = JobMessageLogServiceService.GetJobMessageLogByJobIdDesc(jobid).OrderByDescending(x => x.MessageDateTime)
                   .Select(a => new JobMessageLogGet
                   {
                       JobMessageLogId = a.JobAssignmentId,
                       JobAssignmentId = a.JobAssignmentId,
                       MessageType = a.MessageType,
                       MessageDateTime = a.MessageDateTime,
                       Message = a.Message,
                       JobAssignmentGet = new JobAssignmentGet
                       {
                           JobAssignmentId = JobAssignmentServiceService.GetJobAssignmentById(a.JobAssignmentId).JobAssignmentId,
                           ParticipantID = JobServiceService.GetJobById(jobid).ParticipantId,
                           JobId = JobAssignmentServiceService.GetJobAssignmentById(a.JobAssignmentId).JobId,
                           SupportWorkerId = JobAssignmentServiceService.GetJobAssignmentById(a.JobAssignmentId).SupportWorkerId
                       }
                   })
                   .ToList();

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
    }
}
