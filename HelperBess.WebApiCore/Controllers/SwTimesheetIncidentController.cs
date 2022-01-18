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
    public class SwTimesheetIncidentController : ControllerBase
    {
        private readonly ISwTimesheetIncidentService SwTimesheetIncidentServiceService;
        public SwTimesheetIncidentController(ISwTimesheetIncidentService iSwTimesheetIncidentService)
        {
            SwTimesheetIncidentServiceService = iSwTimesheetIncidentService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/GetSwTimesheetIncident")]
        public IEnumerable<SwTimesheetIncident> GetSwTimesheetIncident()
        {
            return SwTimesheetIncidentServiceService.GetSwTimesheetIncident();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/AddSwTimesheetIncident")]
        public SwTimesheetIncident AddSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncident)
        {
            return SwTimesheetIncidentServiceService.AddSwTimesheetIncident(SwTimesheetIncident);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/UpdateSwTimesheetIncident")]
        public SwTimesheetIncident UpdateSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncident)
        {
            return SwTimesheetIncidentServiceService.UpdateSwTimesheetIncident(SwTimesheetIncident);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/DeleteSwTimesheetIncident")]
        public SwTimesheetIncident DeleteSwTimesheetIncident(int id)
        {
            return SwTimesheetIncidentServiceService.DeleteSwTimesheetIncident(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/GetSwTimesheetIncidentById")]
        public SwTimesheetIncident GetSwTimesheetIncidentById(int id)
        {
            return SwTimesheetIncidentServiceService.GetSwTimesheetIncidentById(id);
        }
    }
}
