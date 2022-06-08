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
    public class ClParticipantReligionController : ControllerBase
    {
        private readonly IClParticipantReligionService ClParticipantReligionServiceService;
        public ClParticipantReligionController(IClParticipantReligionService iClParticipantReligionService)
        {
            ClParticipantReligionServiceService = iClParticipantReligionService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/GetClParticipantReligion")]
        public IActionResult GetClParticipantReligion()
        {
            try
            {
                List<ClParticipantReligion> participantReligions = ClParticipantReligionServiceService.GetClParticipantReligion().ToList();

                if (participantReligions != null && participantReligions.Any())
                {
                    return Ok(participantReligions);
                }
                else
                {
                    return BadRequest("No participant medication religion(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/AddClParticipantReligion")]
        public IActionResult AddClParticipantReligion(ClParticipantReligion ClParticipantReligion)
        {
            try
            {
                ClParticipantReligion participantReligion = ClParticipantReligionServiceService.AddClParticipantReligion(ClParticipantReligion);

                if (participantReligion != null)
                {
                    return Ok(participantReligion);
                }
                else
                {
                    return BadRequest("Failed to add participant religion.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/UpdateClParticipantReligion")]
        public IActionResult UpdateClParticipantReligion(ClParticipantReligion ClParticipantReligion)
        {
            try
            {
                ClParticipantReligion currentParticipantReligion = ClParticipantReligionServiceService.GetClParticipantReligionById(ClParticipantReligion.ParticipantReligionId);

                if (currentParticipantReligion != null)
                {
                    #region Participant Religion to update

                    currentParticipantReligion.ParticipantReligionId = ClParticipantReligion.ParticipantReligionId;
                    currentParticipantReligion.ParticipantId = ClParticipantReligion.ParticipantId;
                    currentParticipantReligion.ReligionId = ClParticipantReligion.ReligionId;

                    #endregion

                    ClParticipantReligion participantReligion = ClParticipantReligionServiceService.UpdateClParticipantReligion(currentParticipantReligion);

                    if (participantReligion != null)
                    {
                        return Ok(participantReligion);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant religion.");
                    }
                }
                else
                {
                    return BadRequest("Participant religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/DeleteClParticipantReligion")]
        public IActionResult DeleteClParticipantReligion(int id)
        {
            try
            {
                ClParticipantReligion currentParticipantReligion = ClParticipantReligionServiceService.GetClParticipantReligionById(id);

                if (currentParticipantReligion != null)
                {
                    ClParticipantReligion participantReligion = ClParticipantReligionServiceService.DeleteClParticipantReligion(id);

                    return Ok(participantReligion);
                }
                else
                {
                    return BadRequest("Participant religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantReligion/GetClParticipantReligionById")]
        public IActionResult GetClParticipantReligionById(int id)
        {
            try
            {
                ClParticipantReligion participantReligion = ClParticipantReligionServiceService.GetClParticipantReligionById(id);

                if (participantReligion != null)
                {
                    return Ok(participantReligion);
                }
                else
                {
                    return BadRequest("Participant religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
