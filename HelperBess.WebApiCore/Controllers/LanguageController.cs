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
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService LanguageServiceService;
        public LanguageController(ILanguageService iLanguageService)
        {
            LanguageServiceService = iLanguageService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Language/GetLanguage")]
        public IActionResult GetLanguage()
        {
            try
            {
                List<Language> languages = LanguageServiceService.GetLanguage().ToList();

                if (languages != null && languages.Any())
                {
                    return Ok(languages);
                }
                else
                {
                    return BadRequest("No language(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Language/AddLanguage")]
        public IActionResult AddLanguage(Language Language)
        {
            try
            {
                Language language = LanguageServiceService.AddLanguage(Language);

                if (language != null)
                {
                    return Ok(language);
                }
                else
                {
                    return BadRequest("Failed to add language.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Language/UpdateLanguage")]
        public IActionResult UpdateLanguage(Language Language)
        {
            try
            {
                Language currentLanguage = LanguageServiceService.GetLanguageById(Language.LanguageId);

                if (currentLanguage != null)
                {
                    #region Language to update

                    currentLanguage.LanguageId = Language.LanguageId;
                    currentLanguage.Language1 = Language.Language1;
                    currentLanguage.DisplayOrder = Language.DisplayOrder;

                    #endregion

                    Language language = LanguageServiceService.UpdateLanguage(currentLanguage);

                    if (language != null)
                    {
                        return Ok(language);
                    }
                    else
                    {
                        return BadRequest("Failed to update language.");
                    }
                }
                else
                {
                    return BadRequest("Language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Language/DeleteLanguage")]
        public IActionResult DeleteLanguage(int id)
        {
            try
            {
                Language currentLanguage = LanguageServiceService.GetLanguageById(id);

                if (currentLanguage != null)
                {
                    Language language = LanguageServiceService.DeleteLanguage(id);

                    return Ok(language);
                }
                else
                {
                    return BadRequest("Language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Language/GetLanguageById")]
        public IActionResult GetLanguageById(int id)
        {
            try
            {
                Language language = LanguageServiceService.GetLanguageById(id);

                if (language != null)
                {
                    return Ok(language);
                }
                else
                {
                    return BadRequest("Language not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
