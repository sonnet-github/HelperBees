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
    public class ClloginAuditController : ControllerBase
    {
        private readonly IClloginAuditService ClloginAuditServiceService;
        public ClloginAuditController(IClloginAuditService iClloginAuditService)
        {
            ClloginAuditServiceService = iClloginAuditService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClloginAudit/GetClloginAudit")]
        public IEnumerable<ClloginAudit> GetClloginAudit()
        {
            return ClloginAuditServiceService.GetClloginAudit();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClloginAudit/AddClloginAudit")]
        public ClloginAudit AddClloginAudit(ClloginAudit ClloginAudit)
        {
            return ClloginAuditServiceService.AddClloginAudit(ClloginAudit);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClloginAudit/UpdateClloginAudit")]
        public ClloginAudit UpdateClloginAudit(ClloginAudit ClloginAudit)
        {
            return ClloginAuditServiceService.UpdateClloginAudit(ClloginAudit);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClloginAudit/DeleteClloginAudit")]
        public ClloginAudit DeleteClloginAudit(int id)
        {
            return ClloginAuditServiceService.DeleteClloginAudit(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClloginAudit/GetClloginAuditById")]
        public ClloginAudit GetClloginAuditById(int id)
        {
            return ClloginAuditServiceService.GetClloginAuditById(id);
        }
    }
}
