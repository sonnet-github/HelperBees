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
    public class SwSupportWorkerCulturalBackgroundController : Controller
    {
        private readonly ISwSupportWorkerCulturalBackgroundService SwSupportWorkerCulturalBackgroundServiceService;
        public SwSupportWorkerCulturalBackgroundController(ISwSupportWorkerCulturalBackgroundService iSwSupportWorkerCulturalBackgroundService)
        {
            SwSupportWorkerCulturalBackgroundServiceService = iSwSupportWorkerCulturalBackgroundService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/GetSwSupportWorkerCulturalBackground")]
        public IActionResult GetSwSupportWorkerCulturalBackground()
        {
            try
            {
                List<SwSupportWorkerCulturalBackground> swCulturalBackgrounds = SwSupportWorkerCulturalBackgroundServiceService.GetSwSupportWorkerCulturalBackground().ToList();

                if (swCulturalBackgrounds != null && swCulturalBackgrounds.Any())
                {
                    return Ok(swCulturalBackgrounds);
                }
                else
                {
                    return BadRequest("No support worker cultural background(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/AddSwSupportWorkerCulturalBackground")]
        public IActionResult AddSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackground)
        {
            try
            {
                SwSupportWorkerCulturalBackground swCulturalBackground = SwSupportWorkerCulturalBackgroundServiceService.AddSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground);

                if (swCulturalBackground != null)
                {
                    return Ok(swCulturalBackground);
                }
                else
                {
                    return BadRequest("Failed to add support worker cultural background.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/UpdateSwSupportWorkerCulturalBackground")]
        public IActionResult UpdateSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackground)
        {
            try
            {
                SwSupportWorkerCulturalBackground swCurrentCulturalBackground = SwSupportWorkerCulturalBackgroundServiceService.GetSwSupportWorkerCulturalBackgroundById(SwSupportWorkerCulturalBackground.SupportWorkerCulturalBackgroundId);

                if (swCurrentCulturalBackground != null)
                {
                    swCurrentCulturalBackground.SupportWorkerCulturalBackgroundId = SwSupportWorkerCulturalBackground.SupportWorkerCulturalBackgroundId;
                    swCurrentCulturalBackground.SupportWorkerId = SwSupportWorkerCulturalBackground.SupportWorkerId;
                    swCurrentCulturalBackground.CulturalBackgroundId = SwSupportWorkerCulturalBackground.CulturalBackgroundId;

                    SwSupportWorkerCulturalBackground swCulturalBackground = SwSupportWorkerCulturalBackgroundServiceService.UpdateSwSupportWorkerCulturalBackground(swCurrentCulturalBackground);

                    if (swCulturalBackground != null)
                    {
                        return Ok(swCulturalBackground);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker cultural background.");
                    }
                }
                else
                {
                    return BadRequest("Support worker cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/DeleteSwSupportWorkerCulturalBackground")]
        public IActionResult DeleteSwSupportWorkerCulturalBackground(int id)
        {
            try
            {
                SwSupportWorkerCulturalBackground swCurrentCulturalBackground = SwSupportWorkerCulturalBackgroundServiceService.GetSwSupportWorkerCulturalBackgroundById(id);

                if (swCurrentCulturalBackground != null)
                {
                    SwSupportWorkerCulturalBackground swCulturalBackground = SwSupportWorkerCulturalBackgroundServiceService.DeleteSwSupportWorkerCulturalBackground(id);

                    return Ok(swCulturalBackground);
                }
                else
                {
                    return BadRequest("Support worker cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/GetSwSupportWorkerCulturalBackgroundById")]
        public IActionResult GetSwSupportWorkerCulturalBackgroundById(int id)
        {
            try
            {
                SwSupportWorkerCulturalBackground swCulturalBackground = SwSupportWorkerCulturalBackgroundServiceService.GetSwSupportWorkerCulturalBackgroundById(id);

                if (swCulturalBackground != null)
                {
                    return Ok(swCulturalBackground);
                }
                else
                {
                    return BadRequest("Support worker cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/GetSwSupportWorkerCulturalBackgroundBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerCulturalBackgroundBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerCulturalBackground> swCulturalBackgrounds = SwSupportWorkerCulturalBackgroundServiceService.GetSwSupportWorkerCulturalBackgroundBySupportWorkerId(supportWorkerId)?.ToList();

                if (swCulturalBackgrounds != null && swCulturalBackgrounds.Any())
                {
                    return Ok(swCulturalBackgrounds);
                }
                else
                {
                    return BadRequest("Support worker cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
