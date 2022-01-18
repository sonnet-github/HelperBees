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
    public class SwloginAuditController : ControllerBase
    {
        private readonly ISwloginAuditService SwloginAuditServiceService;
        public SwloginAuditController(ISwloginAuditService iSwloginAuditService)
        {
            SwloginAuditServiceService = iSwloginAuditService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwloginAudit/GetSwloginAudit")]
        public IEnumerable<SwloginAudit> GetSwloginAudit()
        {
            return SwloginAuditServiceService.GetSwloginAudit();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwloginAudit/AddSwloginAudit")]
        public SwloginAudit AddSwloginAudit(SwloginAudit SwloginAudit)
        {
            return SwloginAuditServiceService.AddSwloginAudit(SwloginAudit);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwloginAudit/UpdateSwloginAudit")]
        public SwloginAudit UpdateSwloginAudit(SwloginAudit SwloginAudit)
        {
            return SwloginAuditServiceService.UpdateSwloginAudit(SwloginAudit);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwloginAudit/DeleteSwloginAudit")]
        public SwloginAudit DeleteSwloginAudit(int id)
        {
            return SwloginAuditServiceService.DeleteSwloginAudit(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwloginAudit/GetSwloginAuditById")]
        public SwloginAudit GetSwloginAuditById(int id)
        {
            return SwloginAuditServiceService.GetSwloginAuditById(id);
        }
    }
}
