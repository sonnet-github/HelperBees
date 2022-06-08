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
    public class ScSupportCoordinatorProfileController : ControllerBase
    {
        private readonly IScSupportCoordinatorProfileService ScSupportCoordinatorProfileServiceService;
        public ScSupportCoordinatorProfileController(IScSupportCoordinatorProfileService iScSupportCoordinatorProfileService)
        {
            ScSupportCoordinatorProfileServiceService = iScSupportCoordinatorProfileService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/GetScSupportCoordinatorProfile")]
        public IActionResult GetScSupportCoordinatorProfile()
        {
            try
            {
                List<ScSupportCoordinatorProfile> supportCoordinatorProfiles = ScSupportCoordinatorProfileServiceService.GetScSupportCoordinatorProfile().ToList();

                if (supportCoordinatorProfiles != null && supportCoordinatorProfiles.Any())
                {
                    return Ok(supportCoordinatorProfiles);
                }
                else
                {
                    return BadRequest("No support coordinator profile(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/AddScSupportCoordinatorProfile")]
        public IActionResult AddScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfile)
        {
            try
            {
                ScSupportCoordinatorProfile supportCoordinatorProfile = ScSupportCoordinatorProfileServiceService.AddScSupportCoordinatorProfile(ScSupportCoordinatorProfile);

                if (supportCoordinatorProfile != null)
                {
                    return Ok(supportCoordinatorProfile);
                }
                else
                {
                    return BadRequest("Failed to add support coordinator profile.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/UpdateScSupportCoordinatorProfile")]
        public IActionResult UpdateScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfile)
        {
            try
            {
                ScSupportCoordinatorProfile currentSupportCoordinatorProfile = ScSupportCoordinatorProfileServiceService.GetScSupportCoordinatorProfileById(ScSupportCoordinatorProfile.SupportCoordinatorProfileId);

                if (currentSupportCoordinatorProfile != null)
                {
                    #region Support Coordinator Profile to update

                    currentSupportCoordinatorProfile.SupportCoordinatorProfileId = ScSupportCoordinatorProfile.SupportCoordinatorProfileId;
                    currentSupportCoordinatorProfile.SupportCoordinatorId = ScSupportCoordinatorProfile.SupportCoordinatorId;
                    currentSupportCoordinatorProfile.FirstName = ScSupportCoordinatorProfile.FirstName;
                    currentSupportCoordinatorProfile.LastName = ScSupportCoordinatorProfile.LastName;

                    #endregion

                    ScSupportCoordinatorProfile supportCoordinatorProfile = ScSupportCoordinatorProfileServiceService.UpdateScSupportCoordinatorProfile(currentSupportCoordinatorProfile);

                    if (supportCoordinatorProfile != null)
                    {
                        return Ok(supportCoordinatorProfile);
                    }
                    else
                    {
                        return BadRequest("Failed to update support coordinator profile.");
                    }
                }
                else
                {
                    return BadRequest("Support coordinator profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/DeleteScSupportCoordinatorProfile")]
        public IActionResult DeleteScSupportCoordinatorProfile(int id)
        {
            try
            {
                ScSupportCoordinatorProfile currentSupportCoordinatorProfile = ScSupportCoordinatorProfileServiceService.GetScSupportCoordinatorProfileById(id);

                if (currentSupportCoordinatorProfile != null)
                {
                    ScSupportCoordinatorProfile supportCoordinatorProfile = ScSupportCoordinatorProfileServiceService.DeleteScSupportCoordinatorProfile(id);

                    return Ok(supportCoordinatorProfile);
                }
                else
                {
                    return BadRequest("Support coordinator profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/GetScSupportCoordinatorProfileById")]
        public IActionResult GetScSupportCoordinatorProfileById(int id)
        {
            try
            {
                ScSupportCoordinatorProfile supportCoordinatorProfile = ScSupportCoordinatorProfileServiceService.GetScSupportCoordinatorProfileById(id);

                if (supportCoordinatorProfile != null)
                {
                    return Ok(supportCoordinatorProfile);
                }
                else
                {
                    return BadRequest("Support coordinator profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
