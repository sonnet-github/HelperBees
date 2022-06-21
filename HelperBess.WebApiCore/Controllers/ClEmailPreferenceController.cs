using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class CLEmailPreferenceController : ControllerBase
    {
        private readonly ICLEmailPreferenceService CLEmailPreferenceServiceService;
        public CLEmailPreferenceController(ICLEmailPreferenceService iCLEmailPreferenceService)
        {
            CLEmailPreferenceServiceService = iCLEmailPreferenceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/CLEmailPreference/GetCLEmailPreference")]
        public IEnumerable<CLEmailPreference> GetCLEmailPreference()
        {
            return CLEmailPreferenceServiceService.GetCLEmailPreference();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/CLEmailPreference/AddCLEmailPreference")]
        public CLEmailPreference AddCLEmailPreference(CLEmailPreference CLEmailPreference)
        {
            return CLEmailPreferenceServiceService.AddCLEmailPreference(CLEmailPreference);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/CLEmailPreference/UpdateCLEmailPreference")]
        public CLEmailPreference UpdateCLEmailPreference(CLEmailPreference CLEmailPreference)
        {
            return CLEmailPreferenceServiceService.UpdateCLEmailPreference(CLEmailPreference);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/CLEmailPreference/DeleteCLEmailPreference")]
        public CLEmailPreference DeleteCLEmailPreference(int id)
        {
            return CLEmailPreferenceServiceService.DeleteCLEmailPreference(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/CLEmailPreference/GetCLEmailPreferenceById")]
        public CLEmailPreference GetCLEmailPreferenceById(int id)
        {
            return CLEmailPreferenceServiceService.GetCLEmailPreferenceById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/CLEmailPreference/GetCLEmailPreferenceBySupportWorkerId")]
        public IEnumerable<CLEmailPreference> GetCLEmailPreferenceBySupportWorkerId(int supportWorkerId)
        {
            return CLEmailPreferenceServiceService.GetCLEmailPreferenceBySupportWorkerId(supportWorkerId);
        }
    }
}
