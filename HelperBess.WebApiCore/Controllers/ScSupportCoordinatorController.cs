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
    public class ScSupportCoordinatorController : ControllerBase
    {
        private readonly IScSupportCoordinatorService ScSupportCoordinatorServiceService;
        public ScSupportCoordinatorController(IScSupportCoordinatorService iScSupportCoordinatorService)
        {
            ScSupportCoordinatorServiceService = iScSupportCoordinatorService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/GetScSupportCoordinator")]
        public IEnumerable<ScSupportCoordinator> GetScSupportCoordinator()
        {
            return ScSupportCoordinatorServiceService.GetScSupportCoordinator();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/AddScSupportCoordinator")]
        public ScSupportCoordinator AddScSupportCoordinator(ScSupportCoordinator ScSupportCoordinator)
        {
            return ScSupportCoordinatorServiceService.AddScSupportCoordinator(ScSupportCoordinator);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/UpdateScSupportCoordinator")]
        public ScSupportCoordinator UpdateScSupportCoordinator(ScSupportCoordinator ScSupportCoordinator)
        {
            return ScSupportCoordinatorServiceService.UpdateScSupportCoordinator(ScSupportCoordinator);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/DeleteScSupportCoordinator")]
        public ScSupportCoordinator DeleteScSupportCoordinator(int id)
        {
            return ScSupportCoordinatorServiceService.DeleteScSupportCoordinator(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinator/GetScSupportCoordinatorById")]
        public ScSupportCoordinator GetScSupportCoordinatorById(int id)
        {
            return ScSupportCoordinatorServiceService.GetScSupportCoordinatorById(id);
        }
    }
}
