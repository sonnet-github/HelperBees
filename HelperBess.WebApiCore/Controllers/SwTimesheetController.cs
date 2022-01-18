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
    public class SwTimesheetController : ControllerBase
    {
        private readonly ISwTimesheetService SwTimesheetServiceService;
        public SwTimesheetController(ISwTimesheetService iSwTimesheetService)
        {
            SwTimesheetServiceService = iSwTimesheetService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheet/GetSwTimesheet")]
        public IEnumerable<SwTimesheet> GetSwTimesheet(int? supportWorkerId = null, int? timesheetStatus = null)
        {
            return SwTimesheetServiceService.GetSwTimesheet(supportWorkerId, timesheetStatus);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTimesheet/AddSwTimesheet")]
        public SwTimesheet AddSwTimesheet(SwTimesheet SwTimesheet)
        {
            return SwTimesheetServiceService.AddSwTimesheet(SwTimesheet);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTimesheet/UpdateSwTimesheet")]
        public SwTimesheet UpdateSwTimesheet(SwTimesheet SwTimesheet)
        {
            return SwTimesheetServiceService.UpdateSwTimesheet(SwTimesheet);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTimesheet/DeleteSwTimesheet")]
        public SwTimesheet DeleteSwTimesheet(int id)
        {
            return SwTimesheetServiceService.DeleteSwTimesheet(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheet/GetSwTimesheetById")]
        public SwTimesheet GetSwTimesheetById(int id)
        {
            return SwTimesheetServiceService.GetSwTimesheetById(id);
        }
    }
}
