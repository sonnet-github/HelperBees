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
        public IEnumerable<ClParticipantLanguage> GetClParticipantLanguage()
        {
            return ClParticipantLanguageServiceService.GetClParticipantLanguage();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/AddClParticipantLanguage")]
        public ClParticipantLanguage AddClParticipantLanguage(ClParticipantLanguage ClParticipantLanguage)
        {
            return ClParticipantLanguageServiceService.AddClParticipantLanguage(ClParticipantLanguage);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/UpdateClParticipantLanguage")]
        public ClParticipantLanguage UpdateClParticipantLanguage(ClParticipantLanguage ClParticipantLanguage)
        {
            return ClParticipantLanguageServiceService.UpdateClParticipantLanguage(ClParticipantLanguage);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/DeleteClParticipantLanguage")]
        public ClParticipantLanguage DeleteClParticipantLanguage(int id)
        {
            return ClParticipantLanguageServiceService.DeleteClParticipantLanguage(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClParticipantLanguage/GetClParticipantLanguageById")]
        public ClParticipantLanguage GetClParticipantLanguageById(int id)
        {
            return ClParticipantLanguageServiceService.GetClParticipantLanguageById(id);
        }
    }
}
