using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public IActionResult GetScimpersonisationLoginAudit()
        {
            try
            {
                List<ScimpersonisationLoginAudit> impersonisationLoginAudits = ScimpersonisationLoginAuditServiceService.GetScimpersonisationLoginAudit().ToList();

                if (impersonisationLoginAudits != null && impersonisationLoginAudits.Any())
                {
                    return Ok(impersonisationLoginAudits);
                }
                else
                {
                    return BadRequest("No impersonisation login audit(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/AddScimpersonisationLoginAudit")]
        public IActionResult AddScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudit)
        {
            try
            {
                ScimpersonisationLoginAudit impersonisationLoginAudit = ScimpersonisationLoginAuditServiceService.AddScimpersonisationLoginAudit(ScimpersonisationLoginAudit);

                if (impersonisationLoginAudit != null)
                {
                    return Ok(impersonisationLoginAudit);
                }
                else
                {
                    return BadRequest("Failed to add impersonisation login audit.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/UpdateScimpersonisationLoginAudit")]
        public IActionResult UpdateScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudit)
        {
            try
            {
                ScimpersonisationLoginAudit currentImpersonisationLoginAudit = ScimpersonisationLoginAuditServiceService.GetScimpersonisationLoginAuditById(ScimpersonisationLoginAudit.ScimpLoginAuditId);

                if (currentImpersonisationLoginAudit != null)
                {
                    #region Impersonisation Login Audit to update

                    currentImpersonisationLoginAudit.ScimpLoginAuditId = ScimpersonisationLoginAudit.ScimpLoginAuditId;
                    currentImpersonisationLoginAudit.SupportCoordinatorId = ScimpersonisationLoginAudit.SupportCoordinatorId;
                    currentImpersonisationLoginAudit.DateTime = ScimpersonisationLoginAudit.DateTime;

                    #endregion

                    ScimpersonisationLoginAudit impersonisationLoginAudit = ScimpersonisationLoginAuditServiceService.UpdateScimpersonisationLoginAudit(currentImpersonisationLoginAudit);

                    if (impersonisationLoginAudit != null)
                    {
                        return Ok(impersonisationLoginAudit);
                    }
                    else
                    {
                        return BadRequest("Failed to update impersonisation login audit.");
                    }
                }
                else
                {
                    return BadRequest("Impersonisation login audit not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/DeleteScimpersonisationLoginAudit")]
        public IActionResult DeleteScimpersonisationLoginAudit(int id)
        {
            try
            {
                ScimpersonisationLoginAudit currentImpersonisationLoginAudit = ScimpersonisationLoginAuditServiceService.GetScimpersonisationLoginAuditById(id);

                if (currentImpersonisationLoginAudit != null)
                {
                    ScimpersonisationLoginAudit impersonisationLoginAudit = ScimpersonisationLoginAuditServiceService.DeleteScimpersonisationLoginAudit(id);

                    return Ok(impersonisationLoginAudit);
                }
                else
                {
                    return BadRequest("Impersonisation login audit not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScimpersonisationLoginAudit/GetScimpersonisationLoginAuditById")]
        public IActionResult GetScimpersonisationLoginAuditById(int id)
        {
            try
            {
                ScimpersonisationLoginAudit impersonisationLoginAudit = ScimpersonisationLoginAuditServiceService.GetScimpersonisationLoginAuditById(id);

                if (impersonisationLoginAudit != null)
                {
                    return Ok(impersonisationLoginAudit);
                }
                else
                {
                    return BadRequest("Impersonisation login audit not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
