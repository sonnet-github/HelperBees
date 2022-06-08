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
    public class ClJobServiceController : ControllerBase
    {
        private readonly IClJobServiceService ClJobServiceServiceService;
        public ClJobServiceController(IClJobServiceService iClJobServiceService)
        {
            ClJobServiceServiceService = iClJobServiceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClJobService/GetClJobService")]
        public IActionResult GetClJobService()
        {
            try
            {
                List<ClJobService> jobServices = ClJobServiceServiceService.GetClJobService().ToList();

                if (jobServices != null && jobServices.Any())
                {
                    return Ok(jobServices);
                }
                else
                {
                    return BadRequest("No job services(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClJobService/AddClJobService")]
        public IActionResult AddClJobService(ClJobService ClJobService)
        {
            try
            {
                ClJobService jobService = ClJobServiceServiceService.AddClJobService(ClJobService);

                if (jobService != null)
                {
                    return Ok(jobService);
                }
                else
                {
                    return BadRequest("Failed to add job service.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClJobService/UpdateClJobService")]
        public IActionResult UpdateClJobService(ClJobService ClJobService)
        {
            try
            {
                ClJobService currentJobService = ClJobServiceServiceService.GetClJobServiceById(ClJobService.JobServiceId);

                if (currentJobService != null)
                {
                    #region Job Service to update

                    currentJobService.JobServiceId = ClJobService.JobServiceId;
                    currentJobService.Description = ClJobService.Description;

                    #endregion

                    ClJobService jobService = ClJobServiceServiceService.UpdateClJobService(currentJobService);

                    if (jobService != null)
                    {
                        return Ok(jobService);
                    }
                    else
                    {
                        return BadRequest("Failed to update job service.");
                    }
                }
                else
                {
                    return BadRequest("Job Service not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClJobService/DeleteClJobService")]
        public IActionResult DeleteClJobService(int id)
        {
            try
            {
                ClJobService currentJobService = ClJobServiceServiceService.GetClJobServiceById(id);

                if (currentJobService != null)
                {
                    ClJobService jobService = ClJobServiceServiceService.DeleteClJobService(id);

                    return Ok(jobService);
                }
                else
                {
                    return BadRequest("Job Service not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClJobService/GetClJobServiceById")]
        public IActionResult GetClJobServiceById(int id)
        {
            try
            {
                ClJobService jobService = ClJobServiceServiceService.GetClJobServiceById(id);

                if (jobService != null)
                {
                    return Ok(jobService);
                }
                else
                {
                    return BadRequest("Job Service not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
