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
        public IEnumerable<SwSupportWorkerLanguage> GetSwSupportWorkerLanguage()
        {
            return SwSupportWorkerLanguageServiceService.GetSwSupportWorkerLanguage();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/AddSwSupportWorkerLanguage")]
        public SwSupportWorkerLanguage AddSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage)
        {
            return SwSupportWorkerLanguageServiceService.AddSwSupportWorkerLanguage(SwSupportWorkerLanguage);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/UpdateSwSupportWorkerLanguage")]
        public SwSupportWorkerLanguage UpdateSwSupportWorkerLanguage(SwSupportWorkerLanguage SwSupportWorkerLanguage)
        {
            return SwSupportWorkerLanguageServiceService.UpdateSwSupportWorkerLanguage(SwSupportWorkerLanguage);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/DeleteSwSupportWorkerLanguage")]
        public SwSupportWorkerLanguage DeleteSwSupportWorkerLanguage(int id)
        {
            return SwSupportWorkerLanguageServiceService.DeleteSwSupportWorkerLanguage(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerLanguage/GetSwSupportWorkerLanguageById")]
        public SwSupportWorkerLanguage GetSwSupportWorkerLanguageById(int id)
        {
            return SwSupportWorkerLanguageServiceService.GetSwSupportWorkerLanguageById(id);
        }
    }
}
