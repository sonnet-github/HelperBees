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
    public class SwTimesheetStatusController : ControllerBase
    {
        private readonly ISwTimesheetStatusService SwTimesheetStatusServiceService;
        public SwTimesheetStatusController(ISwTimesheetStatusService iSwTimesheetStatusService)
        {
            SwTimesheetStatusServiceService = iSwTimesheetStatusService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/GetSwTimesheetStatus")]
        public IEnumerable<SwTimesheetStatus> GetSwTimesheetStatus()
        {
            return SwTimesheetStatusServiceService.GetSwTimesheetStatus();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/AddSwTimesheetStatus")]
        public SwTimesheetStatus AddSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatus)
        {
            return SwTimesheetStatusServiceService.AddSwTimesheetStatus(SwTimesheetStatus);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/UpdateSwTimesheetStatus")]
        public SwTimesheetStatus UpdateSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatus)
        {
            return SwTimesheetStatusServiceService.UpdateSwTimesheetStatus(SwTimesheetStatus);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/DeleteSwTimesheetStatus")]
        public SwTimesheetStatus DeleteSwTimesheetStatus(int id)
        {
            return SwTimesheetStatusServiceService.DeleteSwTimesheetStatus(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/GetSwTimesheetStatusById")]
        public SwTimesheetStatus GetSwTimesheetStatusById(int id)
        {
            return SwTimesheetStatusServiceService.GetSwTimesheetStatusById(id);
        }
    }
}
