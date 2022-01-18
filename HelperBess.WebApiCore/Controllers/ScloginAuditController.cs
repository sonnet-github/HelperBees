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
    public class ScloginAuditController : ControllerBase
    {
        private readonly IScloginAuditService ScloginAuditServiceService;
        public ScloginAuditController(IScloginAuditService iScloginAuditService)
        {
            ScloginAuditServiceService = iScloginAuditService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScloginAudit/GetScloginAudit")]
        public IEnumerable<ScloginAudit> GetScloginAudit()
        {
            return ScloginAuditServiceService.GetScloginAudit();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScloginAudit/AddScloginAudit")]
        public ScloginAudit AddScloginAudit(ScloginAudit ScloginAudit)
        {
            return ScloginAuditServiceService.AddScloginAudit(ScloginAudit);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScloginAudit/UpdateScloginAudit")]
        public ScloginAudit UpdateScloginAudit(ScloginAudit ScloginAudit)
        {
            return ScloginAuditServiceService.UpdateScloginAudit(ScloginAudit);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScloginAudit/DeleteScloginAudit")]
        public ScloginAudit DeleteScloginAudit(int id)
        {
            return ScloginAuditServiceService.DeleteScloginAudit(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScloginAudit/GetScloginAuditById")]
        public ScloginAudit GetScloginAuditById(int id)
        {
            return ScloginAuditServiceService.GetScloginAuditById(id);
        }
    }
}
