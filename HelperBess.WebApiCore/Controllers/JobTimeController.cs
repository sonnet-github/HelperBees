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
        public IActionResult GetJobTime()
        {
            try
            {
                List<JobTime> jobTimes = JobTimeServiceService.GetJobTime().ToList();

                if (jobTimes != null && jobTimes.Any())
                {
                    return Ok(jobTimes);
                }
                else
                {
                    return BadRequest("No job time(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/JobTime/AddJobTime")]
        public IActionResult AddJobTime(JobTime JobTime)
        {
            try
            {
                JobTime newJobTime = JobTimeServiceService.AddJobTime(JobTime);

                if (newJobTime != null)
                {
                    return Ok(newJobTime);
                }
                else
                {
                    return BadRequest("Failed to add job time.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/JobTime/UpdateJobTime")]
        public IActionResult UpdateJobTime(JobTime JobTime)
        {
            try
            {
                JobTime currentJobTime = JobTimeServiceService.GetJobTimeById(JobTime.JobTimesId);

                if (currentJobTime != null)
                {
                    currentJobTime.JobTimesId = JobTime.JobTimesId;
                    currentJobTime.JobId = JobTime.JobId;
                    currentJobTime.DayOfWeek = JobTime.DayOfWeek;
                    currentJobTime.TimeOfDay = JobTime.TimeOfDay;

                    JobTime updatedJobTime = JobTimeServiceService.UpdateJobTime(currentJobTime);

                    if (updatedJobTime != null)
                    {
                        return Ok(updatedJobTime);
                    }
                    else
                    {
                        return BadRequest("Failed to update job time.");
                    }
                }
                else
                {
                    return BadRequest("Job time not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/JobTime/DeleteJobTime")]
        public IActionResult DeleteJobTime(int id)
        {
            try
            {
                JobTime currentJobTime = JobTimeServiceService.GetJobTimeById(id);

                if (currentJobTime != null)
                {
                    JobTime jobTime = JobTimeServiceService.DeleteJobTime(id);

                    return Ok(jobTime);
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
        [Route("api/JobTime/GetJobTimeById")]
        public IActionResult GetJobTimeById(int id)
        {
            try
            {
                JobTime jobTime = JobTimeServiceService.GetJobTimeById(id);

                if (jobTime != null)
                {
                    return Ok(jobTime);
                }
                else
                {
                    return BadRequest("Job time not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
