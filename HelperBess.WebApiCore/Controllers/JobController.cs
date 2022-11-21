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
        public IActionResult GetJob()
        {
            try
            {
                List<Job> jobs = JobServiceService.GetJob().ToList();

                if (jobs != null && jobs.Any())
                {
                    return Ok(jobs);
                }
                else
                {
                    return BadRequest("No job(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Job/SearchJob")]
        public IActionResult SearchJob(string suburb = null, string services = null, string gender = null, string hours = null)
        {
            try
            {
                List<Job> jobs = JobServiceService.SearchJob(suburb, services, gender, hours).ToList();

                if (jobs != null && jobs.Any())
                {
                    return Ok(jobs);
                }
                else
                {
                    return BadRequest("No job(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Job/GetJobByParticipantId")]
        public IActionResult GetJobByParticipantId(int participantId, bool includeArchived = false)
        {
            try
            {
                List<Job> jobs = JobServiceService.GetJobByParticipantId(participantId, includeArchived).ToList();

                if (jobs != null && jobs.Any())
                {
                    return Ok(jobs);
                }
                else
                {
                    return BadRequest("No job(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Job/AddJob")]
        public IActionResult AddJob(Job job)
        {
            try
            {
                Job newJob = JobServiceService.AddJob(job);

                if (newJob != null)
                {
                    return Ok(newJob);
                }
                else
                {
                    return BadRequest("Failed to add job.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Job/UpdateJob")]
        public IActionResult UpdateJob(Job job)
        {
            try
            {
                Job currentJob = JobServiceService.GetJobById(job.JobId);

                if (currentJob != null)
                {
                    currentJob.JobId = job.JobId;
                    currentJob.ParticipantId = job.ParticipantId;
                    currentJob.Suburb = job.Suburb;
                    currentJob.ParticipantDescription = job.ParticipantDescription;
                    currentJob.SupportWorkDescription = job.SupportWorkDescription;
                    currentJob.GenderPreference = job.GenderPreference;
                    currentJob.TypeOfJob = job.TypeOfJob;
                    currentJob.JobDetails = job.JobDetails;
                    currentJob.Hours = job.Hours;
                    currentJob.JobSpecificTimes = job.JobSpecificTimes;
                    currentJob.JobName = job.JobName;
                    currentJob.JobStatus = job.JobStatus;
                    currentJob.DateCreated = job.DateCreated;
                    currentJob.ActivityDescription = job.ActivityDescription;
                    currentJob.PreferredDays = job.PreferredDays;

                    Job updatedJob = JobServiceService.UpdateJob(currentJob);

                    if (updatedJob != null)
                    {
                        return Ok(job);
                    }
                    else
                    {
                        return BadRequest("Failed to update job.");
                    }
                }
                else
                {
                    return BadRequest("Job not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Job/DeleteJob")]
        public IActionResult DeleteJob(int id)
        {
            try
            {
                Job currentJob = JobServiceService.GetJobById(id);

                if (currentJob != null)
                {
                    Job job = JobServiceService.DeleteJob(id);

                    return Ok(job);                    
                }
                else
                {
                    return BadRequest("Job not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Job/GetJobById")]
        public IActionResult GetJobById(int id)
        {
            try
            {
                Job job = JobServiceService.GetJobById(id);

                if (job != null)
                {
                    return Ok(job);
                }
                else
                {
                    return BadRequest("Job not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
