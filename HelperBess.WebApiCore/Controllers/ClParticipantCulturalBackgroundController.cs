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
    public class ClParticipantCulturalBackgroundController : ControllerBase
    {
        private readonly IClParticipantCulturalBackgroundService ClParticipantCulturalBackgroundServiceService;
        public ClParticipantCulturalBackgroundController(IClParticipantCulturalBackgroundService iClParticipantCulturalBackgroundService)
        {
            ClParticipantCulturalBackgroundServiceService = iClParticipantCulturalBackgroundService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/GetClParticipantCulturalBackground")]
        public IActionResult GetClParticipantCulturalBackground()
        {
            try
            {
                List<ClParticipantCulturalBackground> participantCBackgrounds = ClParticipantCulturalBackgroundServiceService.GetClParticipantCulturalBackground().ToList();

                if (participantCBackgrounds != null && participantCBackgrounds.Any())
                {
                    return Ok(participantCBackgrounds);
                }
                else
                {
                    return BadRequest("No participant cultural background(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/AddClParticipantCulturalBackground")]
        public IActionResult AddClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackground)
        {
            try
            {
                ClParticipantCulturalBackground participantCulturalBackground = ClParticipantCulturalBackgroundServiceService.AddClParticipantCulturalBackground(ClParticipantCulturalBackground);

                if (participantCulturalBackground != null)
                {
                    return Ok(participantCulturalBackground);
                }
                else
                {
                    return BadRequest("Failed to add participant cultural background.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/UpdateClParticipantCulturalBackground")]
        public IActionResult UpdateClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackground)
        {
            try
            {
                ClParticipantCulturalBackground currentParticipantCulturalBackground = ClParticipantCulturalBackgroundServiceService.GetClParticipantCulturalBackgroundById(ClParticipantCulturalBackground.ParticipantCulturalBackgroundId);

                if (currentParticipantCulturalBackground != null)
                {
                    #region Participant Cultural Background to update

                    currentParticipantCulturalBackground.ParticipantCulturalBackgroundId = ClParticipantCulturalBackground.ParticipantCulturalBackgroundId;
                    currentParticipantCulturalBackground.ParticipantId = ClParticipantCulturalBackground.ParticipantId;
                    currentParticipantCulturalBackground.CulturalBackgroundId = ClParticipantCulturalBackground.CulturalBackgroundId;

                    #endregion

                    ClParticipantCulturalBackground participantCulturalBackground = ClParticipantCulturalBackgroundServiceService.UpdateClParticipantCulturalBackground(currentParticipantCulturalBackground);

                    if (participantCulturalBackground != null)
                    {
                        return Ok(participantCulturalBackground);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant cultural background.");
                    }
                }
                else
                {
                    return BadRequest("Participant cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/DeleteClParticipantCulturalBackground")]
        public IActionResult DeleteClParticipantCulturalBackground(int id)
        {
            try
            {
                ClParticipantCulturalBackground CurrentParticipantCulturalBackground = ClParticipantCulturalBackgroundServiceService.GetClParticipantCulturalBackgroundById(id);

                if (CurrentParticipantCulturalBackground != null)
                {
                    ClParticipantCulturalBackground participantCulturalBackground = ClParticipantCulturalBackgroundServiceService.DeleteClParticipantCulturalBackground(id);

                    return Ok(participantCulturalBackground);
                }
                else
                {
                    return BadRequest("Participant cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantCulturalBackground/GetClParticipantCulturalBackgroundById")]
        public IActionResult GetClParticipantCulturalBackgroundById(int id)
        {
            try
            {
                ClParticipantCulturalBackground participantCulturalBackground = ClParticipantCulturalBackgroundServiceService.GetClParticipantCulturalBackgroundById(id);

                if (participantCulturalBackground != null)
                {
                    return Ok(participantCulturalBackground);
                }
                else
                {
                    return BadRequest("Participant cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
