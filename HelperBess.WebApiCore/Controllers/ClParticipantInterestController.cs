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
    public class ClParticipantInterestController : ControllerBase
    {
        private readonly IClParticipantInterestService ClParticipantInterestServiceService;
        public ClParticipantInterestController(IClParticipantInterestService iClParticipantInterestService)
        {
            ClParticipantInterestServiceService = iClParticipantInterestService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/GetClParticipantInterest")]
        public IActionResult GetClParticipantInterest()
        {
            try
            {
                List<ClParticipantInterest> participantInterests = ClParticipantInterestServiceService.GetClParticipantInterest().ToList();

                if (participantInterests != null && participantInterests.Any())
                {
                    return Ok(participantInterests);
                }
                else
                {
                    return BadRequest("No participant interest(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/AddClParticipantInterest")]
        public IActionResult AddClParticipantInterest(ClParticipantInterest ClParticipantInterest)
        {
            try
            {
                ClParticipantInterest participantInterest = ClParticipantInterestServiceService.AddClParticipantInterest(ClParticipantInterest);

                if (participantInterest != null)
                {
                    return Ok(participantInterest);
                }
                else
                {
                    return BadRequest("Failed to add participant interest.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/UpdateClParticipantInterest")]
        public IActionResult UpdateClParticipantInterest(ClParticipantInterest ClParticipantInterest)
        {
            try
            {
                ClParticipantInterest currentParticipantInterest = ClParticipantInterestServiceService.GetClParticipantInterestById(ClParticipantInterest.ParticipantInterestsId);

                if (currentParticipantInterest != null)
                {
                    #region Participant Interest to update

                    currentParticipantInterest.ParticipantInterestsId = ClParticipantInterest.ParticipantInterestsId;
                    currentParticipantInterest.ParticipantId = ClParticipantInterest.ParticipantId;
                    currentParticipantInterest.InterestsId = ClParticipantInterest.InterestsId;

                    #endregion

                    ClParticipantInterest participantInterest = ClParticipantInterestServiceService.UpdateClParticipantInterest(currentParticipantInterest);

                    if (participantInterest != null)
                    {
                        return Ok(participantInterest);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant interest.");
                    }
                }
                else
                {
                    return BadRequest("Participant interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/DeleteClParticipantInterest")]
        public IActionResult DeleteClParticipantInterest(int id)
        {
            try
            {
                ClParticipantInterest CurrentParticipantInterest = ClParticipantInterestServiceService.GetClParticipantInterestById(id);

                if (CurrentParticipantInterest != null)
                {
                    ClParticipantInterest participantInterest = ClParticipantInterestServiceService.DeleteClParticipantInterest(id);

                    return Ok(participantInterest);
                }
                else
                {
                    return BadRequest("Participant interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterest/GetClParticipantInterestById")]
        public IActionResult GetClParticipantInterestById(int id)
        {
            try
            {
                ClParticipantInterest participantInterest = ClParticipantInterestServiceService.GetClParticipantInterestById(id);

                if (participantInterest != null)
                {
                    return Ok(participantInterest);
                }
                else
                {
                    return BadRequest("Participant interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
