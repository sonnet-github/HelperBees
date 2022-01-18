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
    public class ScSupportCoordinatorSupportWorkerController : ControllerBase
    {
        private readonly IScSupportCoordinatorSupportWorkerService ScSupportCoordinatorSupportWorkerServiceService;
        public ScSupportCoordinatorSupportWorkerController(IScSupportCoordinatorSupportWorkerService iScSupportCoordinatorSupportWorkerService)
        {
            ScSupportCoordinatorSupportWorkerServiceService = iScSupportCoordinatorSupportWorkerService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/GetScSupportCoordinatorSupportWorker")]
        public IEnumerable<ScSupportCoordinatorSupportWorker> GetScSupportCoordinatorSupportWorker()
        {
            return ScSupportCoordinatorSupportWorkerServiceService.GetScSupportCoordinatorSupportWorker();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/AddScSupportCoordinatorSupportWorker")]
        public ScSupportCoordinatorSupportWorker AddScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorker)
        {
            return ScSupportCoordinatorSupportWorkerServiceService.AddScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/UpdateScSupportCoordinatorSupportWorker")]
        public ScSupportCoordinatorSupportWorker UpdateScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorker)
        {
            return ScSupportCoordinatorSupportWorkerServiceService.UpdateScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/DeleteScSupportCoordinatorSupportWorker")]
        public ScSupportCoordinatorSupportWorker DeleteScSupportCoordinatorSupportWorker(int id)
        {
            return ScSupportCoordinatorSupportWorkerServiceService.DeleteScSupportCoordinatorSupportWorker(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/GetScSupportCoordinatorSupportWorkerById")]
        public ScSupportCoordinatorSupportWorker GetScSupportCoordinatorSupportWorkerById(int id)
        {
            return ScSupportCoordinatorSupportWorkerServiceService.GetScSupportCoordinatorSupportWorkerById(id);
        }
    }
}
