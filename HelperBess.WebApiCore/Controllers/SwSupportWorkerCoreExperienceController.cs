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
    public class SwSupportWorkerCoreExperienceController : ControllerBase
    {

        private readonly ISwSupportWorkerCoreExperienceService SwSupportWorkerCoreExperienceServiceService;
        public SwSupportWorkerCoreExperienceController(ISwSupportWorkerCoreExperienceService iSwSupportWorkerCoreExperienceService)
        {
            SwSupportWorkerCoreExperienceServiceService = iSwSupportWorkerCoreExperienceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/GetSwSupportWorkerCoreExperience")]
        public IEnumerable<SwSupportWorkerCoreExperience> GetSwSupportWorkerCoreExperience()
        {
            return SwSupportWorkerCoreExperienceServiceService.GetSwSupportWorkerCoreExperience();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/AddSwSupportWorkerCoreExperience")]
        public SwSupportWorkerCoreExperience AddSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience)
        {
            return SwSupportWorkerCoreExperienceServiceService.AddSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/UpdateSwSupportWorkerCoreExperience")]
        public SwSupportWorkerCoreExperience UpdateSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience)
        {
            return SwSupportWorkerCoreExperienceServiceService.UpdateSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/DeleteSwSupportWorkerCoreExperience")]
        public SwSupportWorkerCoreExperience DeleteSwSupportWorkerCoreExperience(int id)
        {
            return SwSupportWorkerCoreExperienceServiceService.DeleteSwSupportWorkerCoreExperience(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCoreExperience/GetSwSupportWorkerCoreExperienceById")]
        public SwSupportWorkerCoreExperience GetSwSupportWorkerCoreExperienceById(int id)
        {
            return SwSupportWorkerCoreExperienceServiceService.GetSwSupportWorkerCoreExperienceById(id);
        }
    }
}
