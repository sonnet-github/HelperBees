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
    public class ScSupportCoordinatorProfileController : ControllerBase
    {
        private readonly IScSupportCoordinatorProfileService ScSupportCoordinatorProfileServiceService;
        public ScSupportCoordinatorProfileController(IScSupportCoordinatorProfileService iScSupportCoordinatorProfileService)
        {
            ScSupportCoordinatorProfileServiceService = iScSupportCoordinatorProfileService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/GetScSupportCoordinatorProfile")]
        public IEnumerable<ScSupportCoordinatorProfile> GetScSupportCoordinatorProfile()
        {
            return ScSupportCoordinatorProfileServiceService.GetScSupportCoordinatorProfile();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/AddScSupportCoordinatorProfile")]
        public ScSupportCoordinatorProfile AddScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfile)
        {
            return ScSupportCoordinatorProfileServiceService.AddScSupportCoordinatorProfile(ScSupportCoordinatorProfile);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/UpdateScSupportCoordinatorProfile")]
        public ScSupportCoordinatorProfile UpdateScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfile)
        {
            return ScSupportCoordinatorProfileServiceService.UpdateScSupportCoordinatorProfile(ScSupportCoordinatorProfile);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/DeleteScSupportCoordinatorProfile")]
        public ScSupportCoordinatorProfile DeleteScSupportCoordinatorProfile(int id)
        {
            return ScSupportCoordinatorProfileServiceService.DeleteScSupportCoordinatorProfile(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorProfile/GetScSupportCoordinatorProfileById")]
        public ScSupportCoordinatorProfile GetScSupportCoordinatorProfileById(int id)
        {
            return ScSupportCoordinatorProfileServiceService.GetScSupportCoordinatorProfileById(id);
        }
    }
}
