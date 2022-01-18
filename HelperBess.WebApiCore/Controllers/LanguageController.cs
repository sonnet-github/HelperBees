using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<Language> GetLanguage()
        {
            return LanguageServiceService.GetLanguage();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Language/AddLanguage")]
        public Language AddLanguage(Language Language)
        {
            return LanguageServiceService.AddLanguage(Language);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Language/UpdateLanguage")]
        public Language UpdateLanguage(Language Language)
        {
            return LanguageServiceService.UpdateLanguage(Language);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Language/DeleteLanguage")]
        public Language DeleteLanguage(int id)
        {
            return LanguageServiceService.DeleteLanguage(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Language/GetLanguageById")]
        public Language GetLanguageById(int id)
        {
            return LanguageServiceService.GetLanguageById(id);
        }
    }
}
