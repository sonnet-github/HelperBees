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
    public class SwEmailPreferenceController : ControllerBase
    {
        private readonly ISwEmailPreferenceService SwEmailPreferenceServiceService;
        public SwEmailPreferenceController(ISwEmailPreferenceService iSwEmailPreferenceService)
        {
            SwEmailPreferenceServiceService = iSwEmailPreferenceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEmailPreference/GetSwEmailPreference")]
        public IEnumerable<SwEmailPreference> GetSwEmailPreference()
        {
            return SwEmailPreferenceServiceService.GetSwEmailPreference();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwEmailPreference/AddSwEmailPreference")]
        public SwEmailPreference AddSwEmailPreference(SwEmailPreference SwEmailPreference)
        {
            return SwEmailPreferenceServiceService.AddSwEmailPreference(SwEmailPreference);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwEmailPreference/UpdateSwEmailPreference")]
        public SwEmailPreference UpdateSwEmailPreference(SwEmailPreference SwEmailPreference)
        {
            return SwEmailPreferenceServiceService.UpdateSwEmailPreference(SwEmailPreference);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwEmailPreference/DeleteSwEmailPreference")]
        public SwEmailPreference DeleteSwEmailPreference(int id)
        {
            return SwEmailPreferenceServiceService.DeleteSwEmailPreference(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEmailPreference/GetSwEmailPreferenceById")]
        public SwEmailPreference GetSwEmailPreferenceById(int id)
        {
            return SwEmailPreferenceServiceService.GetSwEmailPreferenceById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwEmailPreference/GetSwEmailPreferenceBySupportWorkerId")]
        public SwEmailPreference GetSwEmailPreferenceBySupportWorkerId(int supportWorkerId)
        {
            return SwEmailPreferenceServiceService.GetSwEmailPreferenceBySupportWorkerId(supportWorkerId);
        }
    }
}
