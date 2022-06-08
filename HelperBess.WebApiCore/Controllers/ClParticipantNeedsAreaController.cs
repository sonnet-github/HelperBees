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
    public class ClParticipantNeedsAreaController : ControllerBase
    {
        private readonly IClParticipantNeedsAreaService ClParticipantNeedsAreaServiceService;
        public ClParticipantNeedsAreaController(IClParticipantNeedsAreaService iClParticipantNeedsAreaService)
        {
            ClParticipantNeedsAreaServiceService = iClParticipantNeedsAreaService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/GetClParticipantNeedsArea")]
        public IActionResult GetClParticipantNeedsArea()
        {
            try
            {
                List<ClParticipantNeedsArea> participantNeedAreas = ClParticipantNeedsAreaServiceService.GetClParticipantNeedsArea().ToList();

                if (participantNeedAreas != null && participantNeedAreas.Any())
                {
                    return Ok(participantNeedAreas);
                }
                else
                {
                    return BadRequest("No participant medication need area(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/AddClParticipantNeedsArea")]
        public IActionResult AddClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsArea)
        {
            try
            {
                ClParticipantNeedsArea participantNeedArea = ClParticipantNeedsAreaServiceService.AddClParticipantNeedsArea(ClParticipantNeedsArea);

                if (participantNeedArea != null)
                {
                    return Ok(participantNeedArea);
                }
                else
                {
                    return BadRequest("Failed to add participant need area.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/UpdateClParticipantNeedsArea")]
        public IActionResult UpdateClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsArea)
        {
            try
            {
                ClParticipantNeedsArea currentParticipantNeedArea = ClParticipantNeedsAreaServiceService.GetClParticipantNeedsAreaById(ClParticipantNeedsArea.ParticipantNeedsAreaId);

                if (currentParticipantNeedArea != null)
                {
                    #region Participant Need Area to update

                    currentParticipantNeedArea.ParticipantNeedsAreaId = ClParticipantNeedsArea.ParticipantNeedsAreaId;
                    currentParticipantNeedArea.Description = ClParticipantNeedsArea.Description;

                    #endregion

                    ClParticipantNeedsArea participantNeedArea = ClParticipantNeedsAreaServiceService.UpdateClParticipantNeedsArea(currentParticipantNeedArea);

                    if (participantNeedArea != null)
                    {
                        return Ok(participantNeedArea);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant need area.");
                    }
                }
                else
                {
                    return BadRequest("Participant need area not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/DeleteClParticipantNeedsArea")]
        public IActionResult DeleteClParticipantNeedsArea(int id)
        {
            try
            {
                ClParticipantNeedsArea CurrentParticipantNeedArea = ClParticipantNeedsAreaServiceService.GetClParticipantNeedsAreaById(id);

                if (CurrentParticipantNeedArea != null)
                {
                    ClParticipantNeedsArea participantNeedArea = ClParticipantNeedsAreaServiceService.DeleteClParticipantNeedsArea(id);

                    return Ok(participantNeedArea);
                }
                else
                {
                    return BadRequest("Participant need area not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeedsArea/GetClParticipantNeedsAreaById")]
        public IActionResult GetClParticipantNeedsAreaById(int id)
        {
            try
            {
                ClParticipantNeedsArea participantNeedArea = ClParticipantNeedsAreaServiceService.GetClParticipantNeedsAreaById(id);

                if (participantNeedArea != null)
                {
                    return Ok(participantNeedArea);
                }
                else
                {
                    return BadRequest("Participant need area not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
