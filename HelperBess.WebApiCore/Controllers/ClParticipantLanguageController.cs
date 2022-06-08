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
    public class ClParticipantLanguageController : ControllerBase
    {
        private readonly IClParticipantLanguageService ClParticipantLanguageServiceService;
        public ClParticipantLanguageController(IClParticipantLanguageService iClParticipantLanguageService)
        {
            ClParticipantLanguageServiceService = iClParticipantLanguageService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/GetClParticipantLanguage")]
        public IActionResult GetClParticipantLanguage()
        {
            try
            {
                List<ClParticipantLanguage> participantLanguages = ClParticipantLanguageServiceService.GetClParticipantLanguage().ToList();

                if (participantLanguages != null && participantLanguages.Any())
                {
                    return Ok(participantLanguages);
                }
                else
                {
                    return BadRequest("No participant language(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/AddClParticipantLanguage")]
        public IActionResult AddClParticipantLanguage(ClParticipantLanguage ClParticipantLanguage)
        {
            try
            {
                ClParticipantLanguage participantLanguage = ClParticipantLanguageServiceService.AddClParticipantLanguage(ClParticipantLanguage);

                if (participantLanguage != null)
                {
                    return Ok(participantLanguage);
                }
                else
                {
                    return BadRequest("Failed to add participant language.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/UpdateClParticipantLanguage")]
        public IActionResult UpdateClParticipantLanguage(ClParticipantLanguage ClParticipantLanguage)
        {
            try
            {
                ClParticipantLanguage currentParticipantLanguage = ClParticipantLanguageServiceService.GetClParticipantLanguageById(ClParticipantLanguage.ParticipantLanguageId);

                if (currentParticipantLanguage != null)
                {
                    #region Participant Language to update

                    currentParticipantLanguage.ParticipantLanguageId = ClParticipantLanguage.ParticipantLanguageId;
                    currentParticipantLanguage.ParticipantId = ClParticipantLanguage.ParticipantId;
                    currentParticipantLanguage.LanguageId = ClParticipantLanguage.LanguageId;
                    currentParticipantLanguage.Type = ClParticipantLanguage.Type;

                    #endregion

                    ClParticipantLanguage participantLanguage = ClParticipantLanguageServiceService.UpdateClParticipantLanguage(currentParticipantLanguage);

                    if (participantLanguage != null)
                    {
                        return Ok(participantLanguage);
                    }
                    else
                    {
                        return BadRequest("Failed to update participant language.");
                    }
                }
                else
                {
                    return BadRequest("Participant language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/DeleteClParticipantLanguage")]
        public IActionResult DeleteClParticipantLanguage(int id)
        {
            try
            {
                ClParticipantLanguage CurrentParticipantLanguage = ClParticipantLanguageServiceService.GetClParticipantLanguageById(id);

                if (CurrentParticipantLanguage != null)
                {
                    ClParticipantLanguage participantLanguage = ClParticipantLanguageServiceService.DeleteClParticipantLanguage(id);

                    return Ok(participantLanguage);
                }
                else
                {
                    return BadRequest("Participant language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/GetClParticipantLanguageById")]
        public IActionResult GetClParticipantLanguageById(int id)
        {
            try
            {
                ClParticipantLanguage participantLanguage = ClParticipantLanguageServiceService.GetClParticipantLanguageById(id);

                if (participantLanguage != null)
                {
                    return Ok(participantLanguage);
                }
                else
                {
                    return BadRequest("Participant language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
