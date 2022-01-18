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
    public class ScimpersonisationLoginAuditController : ControllerBase
    {
        private readonly IScimpersonisationLoginAuditService ScimpersonisationLoginAuditServiceService;
        public ScimpersonisationLoginAuditController(IScimpersonisationLoginAuditService iScimpersonisationLoginAuditService)
        {
            ScimpersonisationLoginAuditServiceService = iScimpersonisationLoginAuditService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/GetScimpersonisationLoginAudit")]
        public IEnumerable<ScimpersonisationLoginAudit> GetScimpersonisationLoginAudit()
        {
            return ScimpersonisationLoginAuditServiceService.GetScimpersonisationLoginAudit();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/AddScimpersonisationLoginAudit")]
        public ScimpersonisationLoginAudit AddScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudit)
        {
            return ScimpersonisationLoginAuditServiceService.AddScimpersonisationLoginAudit(ScimpersonisationLoginAudit);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/UpdateScimpersonisationLoginAudit")]
        public ScimpersonisationLoginAudit UpdateScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudit)
        {
            return ScimpersonisationLoginAuditServiceService.UpdateScimpersonisationLoginAudit(ScimpersonisationLoginAudit);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/DeleteScimpersonisationLoginAudit")]
        public ScimpersonisationLoginAudit DeleteScimpersonisationLoginAudit(int id)
        {
            return ScimpersonisationLoginAuditServiceService.DeleteScimpersonisationLoginAudit(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/GetScimpersonisationLoginAuditById")]
        public ScimpersonisationLoginAudit GetScimpersonisationLoginAuditById(int id)
        {
            return ScimpersonisationLoginAuditServiceService.GetScimpersonisationLoginAuditById(id);
        }
    }
}
