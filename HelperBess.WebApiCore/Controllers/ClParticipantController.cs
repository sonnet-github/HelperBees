using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelperBess.WebApiCore.Controllers
{
    //////[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class ClParticipantController : ControllerBase
    {
        private readonly IClParticipantService ClParticipantServiceService;
        public ClParticipantController(IClParticipantService iClParticipantService)
        {
            ClParticipantServiceService = iClParticipantService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipant/GetClParticipant")]
        public IActionResult GetClParticipant()
        {
            try
            {
                List<ClParticipant> participants = ClParticipantServiceService.GetClParticipant().ToList();

                if (participants != null && participants.Any())
                {
                    return Ok(participants);
                }
                else
                {
                    return BadRequest("No participant(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipant/GetClParticipantsByAccountHolderId")]
        public IActionResult GetClParticipantsByAccountHolderId(int accountHolderId)
        {
            try
            {
                List<ClParticipant> participants = ClParticipantServiceService.GetClParticipantsByAccountHolderId(accountHolderId).ToList();

                if (participants != null && participants.Any())
                {
                    return Ok(participants);
                }
                else
                {
                    return BadRequest("No participant(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipant/AddClParticipant")]
        public IActionResult AddClParticipant(ClParticipant ClParticipant)
        {
            try
            {
                ClParticipant participant = ClParticipantServiceService.AddClParticipant(ClParticipant);

                if (participant != null)
                {
                    return Ok(participant);
                }
                else
                {
                    return BadRequest("Failed to add participant.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipant/UpdateClParticipant")]
        public IActionResult UpdateClParticipant(ClParticipant ClParticipant)
        {
            try
            {
                ClParticipant currentParticipant = ClParticipantServiceService.GetClParticipantById(ClParticipant.ParticpantId);

                if (currentParticipant != null)
                {
                    #region Participant to update

                    currentParticipant.ParticpantId = ClParticipant.ParticpantId;
                    currentParticipant.AccountHolderId = ClParticipant.AccountHolderId;
                    currentParticipant.FirstName = ClParticipant.FirstName;
                    currentParticipant.LastName = ClParticipant.LastName;
                    currentParticipant.Gender = ClParticipant.Gender;
                    currentParticipant.GenderOther = ClParticipant.GenderOther;
                    currentParticipant.Phone = ClParticipant.Phone;
                    currentParticipant.Birthdate = ClParticipant.Birthdate;
                    currentParticipant.EmailAddress = ClParticipant.EmailAddress;
                    currentParticipant.AddressStreet = ClParticipant.AddressStreet;
                    currentParticipant.AddressPostcode = ClParticipant.AddressPostcode;
                    currentParticipant.AddressSuburb = ClParticipant.AddressSuburb;
                    currentParticipant.AddressState = ClParticipant.AddressState;
                    currentParticipant.DangerContactAccept = ClParticipant.DangerContactAccept;
                    currentParticipant.EmergencyContactAccept = ClParticipant.EmergencyContactAccept;
                    currentParticipant.MedicalNeedsGoals = ClParticipant.MedicalNeedsGoals;
                    currentParticipant.LivingWith = ClParticipant.LivingWith;
                    currentParticipant.LivingWithPerson = ClParticipant.LivingWithPerson;                  


        #endregion

        ClParticipant participant = ClParticipantServiceService.UpdateClParticipant(currentParticipant);

                    if (participant != null)
                    {
                        return Ok(participant);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant.");
                    }
                }
                else
                {
                    return BadRequest("Participant not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipant/DeleteClParticipant")]
        public IActionResult DeleteClParticipant(int id)
        {
            try
            {
                ClParticipant CurrentParticipant = ClParticipantServiceService.GetClParticipantById(id);

                if (CurrentParticipant != null)
                {
                    ClParticipant participant = ClParticipantServiceService.DeleteClParticipant(id);

                    return Ok(participant);
                }
                else
                {
                    return BadRequest("Participant not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipant/GetClParticipantById")]
        public IActionResult GetClParticipantById(int id)
        {
            try
            {
                ClParticipant participant = ClParticipantServiceService.GetClParticipantById(id);

                if (participant != null)
                {
                    return Ok(participant);
                }
                else
                {
                    return BadRequest("Participant not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
