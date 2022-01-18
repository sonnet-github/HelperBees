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
    public class SwSupportWorkerProfileController : ControllerBase
    {
        private readonly ISwSupportWorkerProfileService SwSupportWorkerProfileServiceService;
        public SwSupportWorkerProfileController(ISwSupportWorkerProfileService iSwSupportWorkerProfileService)
        {
            SwSupportWorkerProfileServiceService = iSwSupportWorkerProfileService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/GetSwSupportWorkerProfile")]
        public IEnumerable<SwSupportWorkerProfile> GetSwSupportWorkerProfile()
        {
            return SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfile();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/GetSwSupportWorkerProfileByLocation")]
        public IEnumerable<SwSupportWorkerProfile> GetSwSupportWorkerProfileByLocation(string location)
        {
            return SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfileByLocation(location);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/AddSwSupportWorkerProfile")]
        public SwSupportWorkerProfile AddSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfile)
        {
            return SwSupportWorkerProfileServiceService.AddSwSupportWorkerProfile(SwSupportWorkerProfile);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/UpdateSwSupportWorkerProfile")]
        public SwSupportWorkerProfile UpdateSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfile)
        {
            return SwSupportWorkerProfileServiceService.UpdateSwSupportWorkerProfile(SwSupportWorkerProfile);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/DeleteSwSupportWorkerProfile")]
        public SwSupportWorkerProfile DeleteSwSupportWorkerProfile(int id)
        {
            return SwSupportWorkerProfileServiceService.DeleteSwSupportWorkerProfile(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/GetSwSupportWorkerProfileById")]
        public SwSupportWorkerProfile GetSwSupportWorkerProfileById(int id)
        {
            return SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfileById(id);
        }
    }
}
