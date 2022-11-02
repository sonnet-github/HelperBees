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
    public class ClParticipantNeedController : ControllerBase
    {
        private readonly IClParticipantNeedService ClParticipantNeedServiceService;
        public ClParticipantNeedController(IClParticipantNeedService iClParticipantNeedService)
        {
            ClParticipantNeedServiceService = iClParticipantNeedService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/GetClParticipantNeed")]
        public IActionResult GetClParticipantNeed()
        {
            try
            {
                List<ClParticipantNeed> participantNeeds = ClParticipantNeedServiceService.GetClParticipantNeed().ToList();

                if (participantNeeds != null && participantNeeds.Any())
                {
                    return Ok(participantNeeds);
                }
                else
                {
                    return BadRequest("No participant medication need(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/AddClParticipantNeed")]
        public IActionResult AddClParticipantNeed(ClParticipantNeed ClParticipantNeed)
        {
            try
            {
                ClParticipantNeed participantNeed = ClParticipantNeedServiceService.AddClParticipantNeed(ClParticipantNeed);

                if (participantNeed != null)
                {
                    return Ok(participantNeed);
                }
                else
                {
                    return BadRequest("Failed to add participant need.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/UpdateClParticipantNeed")]
        public IActionResult UpdateClParticipantNeed(ClParticipantNeed ClParticipantNeed)
        {
            try
            {
                ClParticipantNeed currentParticipantNeed = ClParticipantNeedServiceService.GetClParticipantNeedById(ClParticipantNeed.ParticipantNeedsId);

                if (currentParticipantNeed != null)
                {
                    #region Participant Need to update

                    currentParticipantNeed.ParticipantNeedsId = ClParticipantNeed.ParticipantNeedsId;
                    currentParticipantNeed.ParticipantId = ClParticipantNeed.ParticipantId;
                    currentParticipantNeed.ParticipantNeedsAreaId = ClParticipantNeed.ParticipantNeedsAreaId;
                    currentParticipantNeed.Description = ClParticipantNeed.Description;

                    #endregion

                    ClParticipantNeed participantNeed = ClParticipantNeedServiceService.UpdateClParticipantNeed(currentParticipantNeed);

                    if (participantNeed != null)
                    {
                        return Ok(participantNeed);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant need.");
                    }
                }
                else
                {
                    return BadRequest("Participant need not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/DeleteClParticipantNeed")]
        public IActionResult DeleteClParticipantNeed(int id)
        {
            try
            {
                ClParticipantNeed CurrentParticipantNeed = ClParticipantNeedServiceService.GetClParticipantNeedById(id);

                if (CurrentParticipantNeed != null)
                {
                    ClParticipantNeed participantNeed = ClParticipantNeedServiceService.DeleteClParticipantNeed(id);

                    return Ok(participantNeed);
                }
                else
                {
                    return BadRequest("Participant need not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/DeleteParticipantNeedbyParticipantId")]
        public IActionResult DeleteParticipantNeedbyParticipantId(int ParticipantId)
        {
            try
            {
                List<ClParticipantNeed> CurrentParticipantNeed = ClParticipantNeedServiceService.GetParticipantNeedByParticipantId(ParticipantId).ToList();

                if (CurrentParticipantNeed != null)
                {
                    List<ClParticipantNeed> participantNeed = ClParticipantNeedServiceService.DeleteParticipantNeedbyParticipantId(ParticipantId).ToList();

                    return Ok(participantNeed);
                }
                else
                {
                    return BadRequest("Participant need not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/GetClParticipantNeedById")]
        public IActionResult GetClParticipantNeedById(int id)
        {
            try
            {
                ClParticipantNeed participantNeed = ClParticipantNeedServiceService.GetClParticipantNeedById(id);

                if (participantNeed != null)
                {
                    return Ok(participantNeed);
                }
                else
                {
                    return BadRequest("Participant need not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantNeed/GetParticipantNeedByParticipantId")]
        public IActionResult GetParticipantNeedByParticipantId(int ParticipantId)
        {

            try
            {
                List<ClParticipantNeed> participantNeeds = ClParticipantNeedServiceService.GetParticipantNeedByParticipantId(ParticipantId).ToList();

                if (participantNeeds != null && participantNeeds.Any())
                {
                    return Ok(participantNeeds);
                }
                else
                {
                    return BadRequest("Participant need not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


            //try
            //{
            //    ClParticipantNeed participantNeed = ClParticipantNeedServiceService.GetParticipantNeedByParticipantId(ParticipantId);

            //    if (participantNeed != null)
            //    {
            //        return Ok(participantNeed);
            //    }
            //    else
            //    {
            //        return BadRequest("Participant need not found.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }

    }
}
