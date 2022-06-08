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
    public class ClParticipantMedicationController : ControllerBase
    {
        private readonly IClParticipantMedicationService ClParticipantMedicationServiceService;
        public ClParticipantMedicationController(IClParticipantMedicationService iClParticipantMedicationService)
        {
            ClParticipantMedicationServiceService = iClParticipantMedicationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/GetClParticipantMedication")]
        public IActionResult GetClParticipantMedication()
        {
            try
            {
                List<ClParticipantMedication> participantMedications = ClParticipantMedicationServiceService.GetClParticipantMedication().ToList();

                if (participantMedications != null && participantMedications.Any())
                {
                    return Ok(participantMedications);
                }
                else
                {
                    return BadRequest("No participant medication(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/AddClParticipantMedication")]
        public IActionResult AddClParticipantMedication(ClParticipantMedication ClParticipantMedication)
        {
            try
            {
                ClParticipantMedication participantMedication = ClParticipantMedicationServiceService.AddClParticipantMedication(ClParticipantMedication);

                if (participantMedication != null)
                {
                    return Ok(participantMedication);
                }
                else
                {
                    return BadRequest("Failed to add participant medication.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/UpdateClParticipantMedication")]
        public IActionResult UpdateClParticipantMedication(ClParticipantMedication ClParticipantMedication)
        {
            try
            {
                ClParticipantMedication currentParticipantMedication = ClParticipantMedicationServiceService.GetClParticipantMedicationById(ClParticipantMedication.ParticipantMedicationId);

                if (currentParticipantMedication != null)
                {
                    #region Participant Medication to update

                    currentParticipantMedication.ParticipantMedicationId = ClParticipantMedication.ParticipantMedicationId;
                    currentParticipantMedication.ParticipantId = ClParticipantMedication.ParticipantId;
                    currentParticipantMedication.Description = ClParticipantMedication.Description;
                    currentParticipantMedication.Medication = ClParticipantMedication.Medication;
                    currentParticipantMedication.Dosage = ClParticipantMedication.Dosage;
                    currentParticipantMedication.Frequency = ClParticipantMedication.Frequency;
                    currentParticipantMedication.ReasonTaken = ClParticipantMedication.ReasonTaken;

                    #endregion

                    ClParticipantMedication participantMedication = ClParticipantMedicationServiceService.UpdateClParticipantMedication(currentParticipantMedication);

                    if (participantMedication != null)
                    {
                        return Ok(participantMedication);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant medication.");
                    }
                }
                else
                {
                    return BadRequest("Participant medication not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/DeleteClParticipantMedication")]
        public IActionResult DeleteClParticipantMedication(int id)
        {
            try
            {
                ClParticipantMedication CurrentParticipantMedication = ClParticipantMedicationServiceService.GetClParticipantMedicationById(id);

                if (CurrentParticipantMedication != null)
                {
                    ClParticipantMedication participantMedication = ClParticipantMedicationServiceService.DeleteClParticipantMedication(id);

                    return Ok(participantMedication);
                }
                else
                {
                    return BadRequest("Participant medication not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantMedication/GetClParticipantMedicationById")]
        public IActionResult GetClParticipantMedicationById(int id)
        {
            try
            {
                ClParticipantMedication participantMedication = ClParticipantMedicationServiceService.GetClParticipantMedicationById(id);

                if (participantMedication != null)
                {
                    return Ok(participantMedication);
                }
                else
                {
                    return BadRequest("Participant medication not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
