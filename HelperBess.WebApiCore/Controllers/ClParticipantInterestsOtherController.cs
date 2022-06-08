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
    public class ClParticipantInterestsOtherController : ControllerBase
    {
        private readonly IClParticipantInterestsOtherService ClParticipantInterestsOtherServiceService;
        public ClParticipantInterestsOtherController(IClParticipantInterestsOtherService iClParticipantInterestsOtherService)
        {
            ClParticipantInterestsOtherServiceService = iClParticipantInterestsOtherService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/GetClParticipantInterestsOther")]
        public IActionResult GetClParticipantInterestsOther()
        {
            try
            {
                List<ClParticipantInterestsOther> participantOtherInterests = ClParticipantInterestsOtherServiceService.GetClParticipantInterestsOther().ToList();

                if (participantOtherInterests != null && participantOtherInterests.Any())
                {
                    return Ok(participantOtherInterests);
                }
                else
                {
                    return BadRequest("No participant other interest(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/AddClParticipantInterestsOther")]
        public IActionResult AddClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOther)
        {
            try
            {
                ClParticipantInterestsOther participantOtherInterest = ClParticipantInterestsOtherServiceService.AddClParticipantInterestsOther(ClParticipantInterestsOther);

                if (participantOtherInterest != null)
                {
                    return Ok(participantOtherInterest);
                }
                else
                {
                    return BadRequest("Failed to add participant other interest.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/UpdateClParticipantInterestsOther")]
        public IActionResult UpdateClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOther)
        {
            try
            {
                ClParticipantInterestsOther currentParticipantOtherInterest = ClParticipantInterestsOtherServiceService.GetClParticipantInterestsOtherById(ClParticipantInterestsOther.ParticipantInterestsOtherId);

                if (currentParticipantOtherInterest != null)
                {
                    #region Participant Other Interest to update

                    currentParticipantOtherInterest.ParticipantInterestsOtherId = ClParticipantInterestsOther.ParticipantInterestsOtherId;
                    currentParticipantOtherInterest.ParticipantId = ClParticipantInterestsOther.ParticipantId;
                    currentParticipantOtherInterest.InterestDescription = ClParticipantInterestsOther.InterestDescription;

                    #endregion

                    ClParticipantInterestsOther participantOtherInterest = ClParticipantInterestsOtherServiceService.UpdateClParticipantInterestsOther(currentParticipantOtherInterest);

                    if (participantOtherInterest != null)
                    {
                        return Ok(participantOtherInterest);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant other interest.");
                    }
                }
                else
                {
                    return BadRequest("Participant other interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/DeleteClParticipantInterestsOther")]
        public IActionResult DeleteClParticipantInterestsOther(int id)
        {
            try
            {
                ClParticipantInterestsOther CurrentParticipantOtherInterest = ClParticipantInterestsOtherServiceService.GetClParticipantInterestsOtherById(id);

                if (CurrentParticipantOtherInterest != null)
                {
                    ClParticipantInterestsOther participantOtherInterest = ClParticipantInterestsOtherServiceService.DeleteClParticipantInterestsOther(id);

                    return Ok(participantOtherInterest);
                }
                else
                {
                    return BadRequest("Participant other interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantInterestsOther/GetClParticipantInterestsOtherById")]
        public IActionResult GetClParticipantInterestsOtherById(int id)
        {
            try
            {
                ClParticipantInterestsOther participantOtherInterest = ClParticipantInterestsOtherServiceService.GetClParticipantInterestsOtherById(id);

                if (participantOtherInterest != null)
                {
                    return Ok(participantOtherInterest);
                }
                else
                {
                    return BadRequest("Participant other interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
