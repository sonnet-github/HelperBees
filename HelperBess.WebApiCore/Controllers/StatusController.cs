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
    public class StatusController : ControllerBase
    {
        private readonly IStatusService StatusServiceService;
        public StatusController(IStatusService iStatusService)
        {
            StatusServiceService = iStatusService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Status/GetStatus")]
        public IEnumerable<Status> GetStatus()
        {
            return StatusServiceService.GetStatus();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Status/AddStatus")]
        public Status AddStatus(Status Status)
        {
            return StatusServiceService.AddStatus(Status);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Status/UpdateStatus")]
        public Status UpdateStatus(Status Status)
        {
            return StatusServiceService.UpdateStatus(Status);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Status/DeleteStatus")]
        public Status DeleteStatus(int id)
        {
            return StatusServiceService.DeleteStatus(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Status/GetStatusById")]
        public Status GetStatusById(int id)
        {
            return StatusServiceService.GetStatusById(id);
        }
    }
}
