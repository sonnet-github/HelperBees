using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    ////////////////[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class ChangeLogController : ControllerBase
    {
        private readonly IChangeLogService ChangeLogServiceService;
        public ChangeLogController(IChangeLogService iChangeLogService)
        {
            ChangeLogServiceService = iChangeLogService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ChangeLog/GetChangeLog")]
        //[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin": "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public IEnumerable<ChangeLog> GetChangeLog()
        {
            return ChangeLogServiceService.GetChangeLog();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ChangeLog/AddChangeLog")]
        public ChangeLog AddChangeLog(ChangeLog Changelog)
        {
            return ChangeLogServiceService.AddChangeLog(Changelog);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ChangeLog/UpdateChangeLog")]
        public ChangeLog UpdateChangeLog(ChangeLog Changelog)
        {
            return ChangeLogServiceService.UpdateChangeLog(Changelog);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ChangeLog/DeleteChangeLog")]
        public ChangeLog DeleteChangeLog(int id)
        {
            return ChangeLogServiceService.DeleteChangeLog(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ChangeLog/GetChangeLogById")]
        public ChangeLog GetChangeLogById(int id)
        {
            return ChangeLogServiceService.GetChangeLogById(id);
        }
    }
}
