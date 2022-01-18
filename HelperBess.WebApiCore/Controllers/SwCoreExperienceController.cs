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
    public class SwCoreExperienceController : ControllerBase
    {
        private readonly ISwCoreExperienceService SwCoreExperienceServiceService;
        public SwCoreExperienceController(ISwCoreExperienceService iSwCoreExperienceService)
        {
            SwCoreExperienceServiceService = iSwCoreExperienceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwCoreExperience/GetSwCoreExperience")]
        public IEnumerable<SwCoreExperience> GetSwCoreExperience()
        {
            return SwCoreExperienceServiceService.GetSwCoreExperience();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwCoreExperience/AddSwCoreExperience")]
        public SwCoreExperience AddSwCoreExperience(SwCoreExperience SwCoreExperience)
        {
            return SwCoreExperienceServiceService.AddSwCoreExperience(SwCoreExperience);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwCoreExperience/UpdateSwCoreExperience")]
        public SwCoreExperience UpdateSwCoreExperience(SwCoreExperience SwCoreExperience)
        {
            return SwCoreExperienceServiceService.UpdateSwCoreExperience(SwCoreExperience);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwCoreExperience/DeleteSwCoreExperience")]
        public SwCoreExperience DeleteSwCoreExperience(int id)
        {
            return SwCoreExperienceServiceService.DeleteSwCoreExperience(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwCoreExperience/GetSwCoreExperienceById")]
        public SwCoreExperience GetSwCoreExperienceById(int id)
        {
            return SwCoreExperienceServiceService.GetSwCoreExperienceById(id);
        }
    }
}
