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
    public class SwSupportWorkerLanguageController : ControllerBase
    {
        private readonly ISwSupportWorkerLanguageService SwSupportWorkerLanguageServiceService;
        public SwSupportWorkerLanguageController(ISwSupportWorkerLanguageService iSwSupportWorkerLanguageService)
        {
            SwSupportWorkerLanguageServiceService = iSwSupportWorkerLanguageService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/GetSwSupportWorkerLanguage")]
        public IActionResult GetSwSupportWorkerLanguage()
        {
            try
            {
                List<SwSupportWorkerLanguage> swLanguages = SwSupportWorkerLanguageServiceService.GetSwSupportWorkerLanguage().ToList();

                if (swLanguages != null && swLanguages.Any())
                {
                    return Ok(swLanguages);
                }
                else
                {
                    return BadRequest("No support worker language(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/AddSwSupportWorkerLanguage")]
        public IActionResult AddSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage)
        {
            try
            {
                SwSupportWorkerLanguage swLanguage = SwSupportWorkerLanguageServiceService.AddSwSupportWorkerLanguage(SwSupportWorkerLanguage);

                if (swLanguage != null)
                {
                    return Ok(swLanguage);
                }
                else
                {
                    return BadRequest("Failed to add support worker language.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/UpdateSwSupportWorkerLanguage")]
        public IActionResult UpdateSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage)
        {
            try
            {
                SwSupportWorkerLanguage swCurrentLanguage = SwSupportWorkerLanguageServiceService.GetSwSupportWorkerLanguageById(SwSupportWorkerLanguage.SupportWorkerLanguageId);

                if (swCurrentLanguage != null)
                {
                    swCurrentLanguage.SupportWorkerLanguageId = SwSupportWorkerLanguage.SupportWorkerLanguageId;
                    swCurrentLanguage.SupportWorkerId = SwSupportWorkerLanguage.SupportWorkerId;
                    swCurrentLanguage.LanguageId = SwSupportWorkerLanguage.LanguageId;

                    SwSupportWorkerLanguage swLanguage = SwSupportWorkerLanguageServiceService.UpdateSwSupportWorkerLanguage(SwSupportWorkerLanguage);

                    if (swLanguage != null)
                    {
                        return Ok(swLanguage);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker language.");
                    }
                }
                else
                {
                    return BadRequest("Support worker language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/DeleteSwSupportWorkerLanguage")]
        public IActionResult DeleteSwSupportWorkerLanguage(int id)
        {
            try
            {
                SwSupportWorkerLanguage swCurrentLanguage = SwSupportWorkerLanguageServiceService.GetSwSupportWorkerLanguageById(id);

                if (swCurrentLanguage != null)
                {
                    SwSupportWorkerLanguage swLanguage = SwSupportWorkerLanguageServiceService.DeleteSwSupportWorkerLanguage(id);

                    return Ok(swLanguage);
                }
                else
                {
                    return BadRequest("Support worker language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/GetSwSupportWorkerLanguageById")]
        public IActionResult GetSwSupportWorkerLanguageById(int id)
        {
            try
            {
                SwSupportWorkerLanguage swLanguage = SwSupportWorkerLanguageServiceService.GetSwSupportWorkerLanguageById(id);

                if (swLanguage != null)
                {
                    return Ok(swLanguage);
                }
                else
                {
                    return BadRequest("Support worker language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/GetSwSupportWorkerLanguageBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerLanguageBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerLanguage> swLanguages = SwSupportWorkerLanguageServiceService.GetSwSupportWorkerLanguageBySupportWorkerId(supportWorkerId)?.ToList();

                if (swLanguages != null && swLanguages.Any())
                {
                    return Ok(swLanguages);
                }
                else
                {
                    return NotFound("Support worker language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
