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
    public class SwSupportWorkerCoreExperienceController : ControllerBase
    {

        private readonly ISwSupportWorkerCoreExperienceService SwSupportWorkerCoreExperienceServiceService;
        public SwSupportWorkerCoreExperienceController(ISwSupportWorkerCoreExperienceService iSwSupportWorkerCoreExperienceService)
        {
            SwSupportWorkerCoreExperienceServiceService = iSwSupportWorkerCoreExperienceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/GetSwSupportWorkerCoreExperience")]
        public IActionResult GetSwSupportWorkerCoreExperience()
        {
            try
            {
                List<SwSupportWorkerCoreExperience> swCoreExperiences = SwSupportWorkerCoreExperienceServiceService.GetSwSupportWorkerCoreExperience().ToList();

                if (swCoreExperiences != null && swCoreExperiences.Any())
                {
                    return Ok(swCoreExperiences);
                }
                else
                {
                    return BadRequest("No support worker core experience(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/AddSwSupportWorkerCoreExperience")]
        public IActionResult AddSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience)
        {
            try
            {
                SwSupportWorkerCoreExperience swCoreExperience = SwSupportWorkerCoreExperienceServiceService.AddSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience);

                if (swCoreExperience != null)
                {
                    return Ok(swCoreExperience);
                }
                else
                {
                    return BadRequest("Failed to add support worker core experience.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/UpdateSwSupportWorkerCoreExperience")]
        public IActionResult UpdateSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience)
        {
            try
            {
                SwSupportWorkerCoreExperience swCurrentCoreExperience = SwSupportWorkerCoreExperienceServiceService.GetSwSupportWorkerCoreExperienceById(SwSupportWorkerCoreExperience.SupportWorkerCoreExperienceId);

                if (swCurrentCoreExperience != null)
                {
                    swCurrentCoreExperience.SupportWorkerCoreExperienceId = SwSupportWorkerCoreExperience.SupportWorkerCoreExperienceId;
                    swCurrentCoreExperience.SupportWorkerId = SwSupportWorkerCoreExperience.SupportWorkerId;
                    swCurrentCoreExperience.CoreExperienceId = SwSupportWorkerCoreExperience.CoreExperienceId;

                    SwSupportWorkerCoreExperience swCoreExperience = SwSupportWorkerCoreExperienceServiceService.UpdateSwSupportWorkerCoreExperience(swCurrentCoreExperience);

                    if (swCoreExperience != null)
                    {
                        return Ok(swCoreExperience);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker core experience.");
                    }
                }
                else
                {
                    return BadRequest("Support worker core experience not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/DeleteSwSupportWorkerCoreExperience")]
        public IActionResult DeleteSwSupportWorkerCoreExperience(int id)
        {
            try
            {
                SwSupportWorkerCoreExperience swCurrentCoreExperience = SwSupportWorkerCoreExperienceServiceService.GetSwSupportWorkerCoreExperienceById(id);

                if (swCurrentCoreExperience != null)
                {
                    SwSupportWorkerCoreExperience swCoreExperience = SwSupportWorkerCoreExperienceServiceService.DeleteSwSupportWorkerCoreExperience(id);

                    return Ok(swCoreExperience);
                }
                else
                {
                    return BadRequest("Support worker core experience not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/GetSwSupportWorkerCoreExperienceById")]
        public IActionResult GetSwSupportWorkerCoreExperienceById(int id)
        {
            try
            {
                SwSupportWorkerCoreExperience swCoreExperience = SwSupportWorkerCoreExperienceServiceService.GetSwSupportWorkerCoreExperienceById(id);

                if (swCoreExperience != null)
                {
                    return Ok(swCoreExperience);
                }
                else
                {
                    return BadRequest("Support worker core experience not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/GetSwSupportWorkerCoreExperienceBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerCoreExperienceBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerCoreExperience> swCoreExperiences = SwSupportWorkerCoreExperienceServiceService.GetSwSupportWorkerCoreExperienceBySupportWorkerId(supportWorkerId)?.ToList();

                if (swCoreExperiences != null && swCoreExperiences.Any())
                {
                    return Ok(swCoreExperiences);
                }
                else
                {
                    return NotFound("Support worker core experience not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
