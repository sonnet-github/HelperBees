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
    public class ScSupportCoordinatorController : ControllerBase
    {
        private readonly IScSupportCoordinatorService ScSupportCoordinatorServiceService;
        public ScSupportCoordinatorController(IScSupportCoordinatorService iScSupportCoordinatorService)
        {
            ScSupportCoordinatorServiceService = iScSupportCoordinatorService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/GetScSupportCoordinator")]
        public IActionResult GetScSupportCoordinator()
        {
            try
            {
                List<ScSupportCoordinator> supportCoordinators = ScSupportCoordinatorServiceService.GetScSupportCoordinator().ToList();

                if (supportCoordinators != null && supportCoordinators.Any())
                {
                    return Ok(supportCoordinators);
                }
                else
                {
                    return BadRequest("No support coordinator(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/AddScSupportCoordinator")]
        public IActionResult AddScSupportCoordinator(ScSupportCoordinator ScSupportCoordinator)
        {
            try
            {
                ScSupportCoordinator currentCoordinator = ScSupportCoordinatorServiceService.GetScSupportCoordinatorByEmail(ScSupportCoordinator.EmailAddress);

                if (currentCoordinator == null)
                {
                    ScSupportCoordinator supportCoordinator = ScSupportCoordinatorServiceService.AddScSupportCoordinator(ScSupportCoordinator);

                    if (supportCoordinator != null)
                    {
                        return Ok(supportCoordinator);
                    }
                    else
                    {
                        return BadRequest("Failed to add support coordinator.");
                    }
                }
                else
                {
                    return BadRequest($"E-mail address {ScSupportCoordinator.EmailAddress} is already used by another account holder.");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/UpdateScSupportCoordinator")]
        public IActionResult UpdateScSupportCoordinator(ScSupportCoordinator ScSupportCoordinator)
        {
            try
            {
                ScSupportCoordinator currentSupportCoordinator = ScSupportCoordinatorServiceService.GetScSupportCoordinatorById(ScSupportCoordinator.SupportCoordinatorId);

                if (currentSupportCoordinator != null)
                {
                    #region Support Coordinator to update

                    currentSupportCoordinator.SupportCoordinatorId = ScSupportCoordinator.SupportCoordinatorId;
                    currentSupportCoordinator.EmailAddress = ScSupportCoordinator.EmailAddress;
                    currentSupportCoordinator.Password = ScSupportCoordinator.Password;
                    currentSupportCoordinator.FailedLoginCount = ScSupportCoordinator.FailedLoginCount;
                    currentSupportCoordinator.DateCreated = ScSupportCoordinator.DateCreated;
                    currentSupportCoordinator.StatusId = ScSupportCoordinator.StatusId;
                    currentSupportCoordinator.Locked = ScSupportCoordinator.Locked;
                    currentSupportCoordinator.Active = ScSupportCoordinator.Active;

                    #endregion

                    ScSupportCoordinator supportCoordinator = ScSupportCoordinatorServiceService.UpdateScSupportCoordinator(currentSupportCoordinator);

                    if (supportCoordinator != null)
                    {
                        return Ok(supportCoordinator);
                    }
                    else
                    {
                        return BadRequest("Failed to update support coordinator.");
                    }
                }
                else
                {
                    return BadRequest("Support coordinator not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/DeleteScSupportCoordinator")]
        public IActionResult DeleteScSupportCoordinator(int id)
        {
            try
            {
                ScSupportCoordinator currentSupportCoordinator = ScSupportCoordinatorServiceService.GetScSupportCoordinatorById(id);

                if (currentSupportCoordinator != null)
                {
                    ScSupportCoordinator supportCoordinator = ScSupportCoordinatorServiceService.DeleteScSupportCoordinator(id);

                    return Ok(supportCoordinator);
                }
                else
                {
                    return BadRequest("Support coordinator not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/GetScSupportCoordinatorById")]
        public IActionResult GetScSupportCoordinatorById(int id)
        {
            try
            {
                ScSupportCoordinator supportCoordinator = ScSupportCoordinatorServiceService.GetScSupportCoordinatorById(id);

                if (supportCoordinator != null)
                {
                    return Ok(supportCoordinator);
                }
                else
                {
                    return BadRequest("Support coordinator not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/GetScSupportCoordinatorByEmail")]
        public IActionResult GetScSupportCoordinatorByEmail(string emailaddress)
        {
            try
            {
                ScSupportCoordinator supportCoordinator = ScSupportCoordinatorServiceService.GetScSupportCoordinatorByEmail(emailaddress);

                if (supportCoordinator != null)
                {
                    return Ok(supportCoordinator);
                }
                else
                {
                    return BadRequest("Support coordinator not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
