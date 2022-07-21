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
        public IActionResult GetJobAssignment()
        {
            try
            {
                List<JobAssignment> assignments = JobAssignmentServiceService.GetJobAssignment().ToList();

                if (assignments != null && assignments.Any())
                {
                    return Ok(assignments);
                }
                else
                {
                    return BadRequest("No available job assignment(s).");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/JobAssignment/AddJobAssignment")]
        public IActionResult AddJobAssignment(JobAssignment JobAssignment)
        {
            try
            {
                JobAssignment assignment = JobAssignmentServiceService.AddJobAssignment(JobAssignment);

                if (assignment != null)
                {
                    return Ok(assignment);
                }
                else
                {
                    return BadRequest("Failed to add account holder profile.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/JobAssignment/UpdateJobAssignment")]
        public IActionResult UpdateJobAssignment(JobAssignment jobAssignment)
        {
            try
            {
                JobAssignment currentAssignment = JobAssignmentServiceService.GetJobAssignmentById(jobAssignment.JobAssignmentId);

                if (currentAssignment != null)
                {
                    currentAssignment.JobAssignmentId = jobAssignment.JobAssignmentId;
                    currentAssignment.JobId = jobAssignment.JobId;
                    currentAssignment.SupportWorkerId = jobAssignment.SupportWorkerId;
                    currentAssignment.Alerts = jobAssignment.Alerts;
                    currentAssignment.DateAssigned = jobAssignment.DateAssigned;

                    JobAssignment assignment = JobAssignmentServiceService.UpdateJobAssignment(currentAssignment);

                    if (assignment != null)
                    {
                        return Ok(assignment);
                    }
                    else
                    {
                        return BadRequest("Failed to update job assignment.");
                    }
                }
                else
                {
                    return BadRequest("Job assignment not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/JobAssignment/DeleteJobAssignment")]
        public IActionResult DeleteJobAssignment(int id)
        {
            try
            {
                JobAssignment currentAssignment = JobAssignmentServiceService.GetJobAssignmentById(id);

                if (currentAssignment != null)
                {
                    JobAssignment assignment = JobAssignmentServiceService.DeleteJobAssignment(id);

                    return Ok(assignment);
                }
                else
                {
                    return BadRequest("Job assignment not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobAssignment/GetJobAssignmentById")]
        public IActionResult GetJobAssignmentById(int id)
        {
            try
            {
                JobAssignment assignment = JobAssignmentServiceService.GetJobAssignmentById(id);

                if (assignment != null)
                {
                    return Ok(assignment);
                }
                else
                {
                    return BadRequest("Job assignment not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobAssignment/GetJobAssignmentByParticipantId")]
        public IActionResult GetJobAssignmentByParticipantId(int participantId)
        {
            try
            {
                List<JobAssignment> assignments = JobAssignmentServiceService.GetJobAssignmentByParticipantId(participantId)?.ToList();

                if (assignments != null && assignments.Any())
                {
                    return Ok(assignments);
                }
                else
                {
                    return NotFound("Job assignment not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobAssignment/GetJobAssignmentByJobId")]
        public IActionResult GetJobAssignmentByJobId(int jobid)
        {
            try
            {
                List<JobAssignment> assignments = JobAssignmentServiceService.GetJobAssignmentByJobId(jobid)?.ToList();

                if (assignments != null && assignments.Any())
                {
                    return Ok(assignments);
                }
                else
                {
                    return NotFound("Job assignment not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobAssignment/GetJobAssignmentBySWId")]
        public IActionResult GetJobAssignmentBySWId(int swid)
        {
            try
            {
                List<JobAssignment> assignments = JobAssignmentServiceService.GetJobAssignmentBySWId(swid)?.ToList();

                if (assignments != null && assignments.Any())
                {
                    return Ok(assignments);
                }
                else
                {
                    return NotFound("Job assignment not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/JobAssignment/GetActiveJobAssignmentBySWId")]
        public IActionResult GetActiveJobAssignmentBySWId(int swid)
        {
            try
            {
                List<JobAssignment> assignments = JobAssignmentServiceService.GetActiveJobAssignmentBySWId(swid)?.ToList();

                if (assignments != null && assignments.Any())
                {
                    return Ok(assignments);
                }
                else
                {
                    return NotFound("Job assignment not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
