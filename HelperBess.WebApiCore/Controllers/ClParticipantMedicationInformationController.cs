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
    public class ClParticipantMedicationInformationController : ControllerBase
    {
        private readonly IClParticipantMedicationInformationService ClParticipantMedicationInformationServiceService;
        public ClParticipantMedicationInformationController(IClParticipantMedicationInformationService iClParticipantMedicationInformationService)
        {
            ClParticipantMedicationInformationServiceService = iClParticipantMedicationInformationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/GetClParticipantMedicationInformation")]
        public IActionResult GetClParticipantMedicationInformation()
        {
            try
            {
                List<ClParticipantMedicationInformation> participantMedicationInformations = ClParticipantMedicationInformationServiceService.GetClParticipantMedicationInformation().ToList();

                if (participantMedicationInformations != null && participantMedicationInformations.Any())
                {
                    return Ok(participantMedicationInformations);
                }
                else
                {
                    return BadRequest("No participant medication information(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/AddClParticipantMedicationInformation")]
        public IActionResult AddClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformation)
        {
            try
            {
                ClParticipantMedicationInformation participantMedicationInformation = ClParticipantMedicationInformationServiceService.AddClParticipantMedicationInformation(ClParticipantMedicationInformation);

                if (participantMedicationInformation != null)
                {
                    return Ok(participantMedicationInformation);
                }
                else
                {
                    return BadRequest("Failed to add participant medication information.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/UpdateClParticipantMedicationInformation")]
        public IActionResult UpdateClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformation)
        {
            try
            {
                ClParticipantMedicationInformation currentParticipantMedicationInformation = ClParticipantMedicationInformationServiceService.GetClParticipantMedicationInformationById(ClParticipantMedicationInformation.ParticipantMedicationInformationId);

                if (currentParticipantMedicationInformation != null)
                {
                    #region Participant Medication Information to update

                    currentParticipantMedicationInformation.ParticipantMedicationInformationId = ClParticipantMedicationInformation.ParticipantMedicationInformationId;
                    currentParticipantMedicationInformation.ParticipantId = ClParticipantMedicationInformation.ParticipantId;
                    currentParticipantMedicationInformation.SupportWorkerInstructions = ClParticipantMedicationInformation.SupportWorkerInstructions;
                    currentParticipantMedicationInformation.CarePlan = ClParticipantMedicationInformation.CarePlan;
                    currentParticipantMedicationInformation.Gpdocuments = ClParticipantMedicationInformation.Gpdocuments;
                    currentParticipantMedicationInformation.OtherDocuments = ClParticipantMedicationInformation.OtherDocuments;

                    #endregion

                    ClParticipantMedicationInformation participantMedicationInformation = ClParticipantMedicationInformationServiceService.UpdateClParticipantMedicationInformation(currentParticipantMedicationInformation);

                    if (participantMedicationInformation != null)
                    {
                        return Ok(participantMedicationInformation);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant medication information.");
                    }
                }
                else
                {
                    return BadRequest("Participant medication information not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/DeleteClParticipantMedicationInformation")]
        public IActionResult DeleteClParticipantMedicationInformation(int id)
        {
            try
            {
                ClParticipantMedicationInformation CurrentParticipantMedicationInformation = ClParticipantMedicationInformationServiceService.GetClParticipantMedicationInformationById(id);

                if (CurrentParticipantMedicationInformation != null)
                {
                    ClParticipantMedicationInformation participantMedicationInformation = ClParticipantMedicationInformationServiceService.DeleteClParticipantMedicationInformation(id);

                    return Ok(participantMedicationInformation);
                }
                else
                {
                    return BadRequest("Participant medication information not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedicationInformation/GetClParticipantMedicationInformationById")]
        public IActionResult GetClParticipantMedicationInformationById(int id)
        {
            try
            {
                ClParticipantMedicationInformation participantMedicationInformation = ClParticipantMedicationInformationServiceService.GetClParticipantMedicationInformationById(id);

                if (participantMedicationInformation != null)
                {
                    return Ok(participantMedicationInformation);
                }
                else
                {
                    return BadRequest("Participant medication information not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
